using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class CajeroLN
    {
        private CajeroAD cajeroAD;

        public CajeroLN(CajeroAD cajeroAD)
        {
            this.cajeroAD = cajeroAD;
        }

        private string? ValidarDatos(Cajero cajero)
        {
            if (string.IsNullOrWhiteSpace(cajero.Identificacion))
            {
                return "La identificación no puede estar vacía.";
            }

            if (!long.TryParse(cajero.Identificacion, out long identificacion)
                || identificacion <= 0)
            {
                return "La identificación debe ser un número mayor que cero.";
            }

            if (string.IsNullOrWhiteSpace(cajero.Nombre))
            {
                return "El nombre no puede estar vacío.";
            }

            if (string.IsNullOrWhiteSpace(cajero.Apellido))
            {
                return "El apellido no puede estar vacío.";
            }

            if (cajero.FechaNacimiento >= DateTime.Today)
            {
                return "La fecha de nacimiento no es válida.";
            }

            if (cajero.FechaNacimiento.AddYears(18) > DateTime.Today)
            {
                return "El cajero debe ser mayor de edad.";
            }

            if (cajero.FechaIngreso < cajero.FechaNacimiento)
            {
                return "La fecha de ingreso no puede ser menor que la fecha de nacimiento.";
            }

            if (cajero.FechaIngreso > DateTime.Today)
            {
                return "La fecha de ingreso no puede ser mayor al día actual.";
            }

            return null;
        }

        public string? Registrar(Cajero cajero)
        {
            if (cajeroAD.BuscarPorID(cajero.IdCajero) != null)
            {
                return "El ID del cajero ya existe.";
            }

            if (cajeroAD.BuscarPorIdentificacion(
                cajero.Identificacion) != null)
            {
                return "La identificación del cajero ya existe.";
            }

            string? error = ValidarDatos(cajero);

            if (error != null)
            {
                return error;
            }

            if (!cajeroAD.Agregar(cajero))
            {
                return "No hay espacio para registrar más cajeros.";
            }

            return null;
        }

        public Cajero? BuscarPorID(int id)
        {
            return cajeroAD.BuscarPorID(id);
        }

        public Cajero[] Listar()
        {
            return cajeroAD.Listar();
        }

        public string? Actualizar(Cajero cajero)
        {
            Cajero? cajeroExistente =
                cajeroAD.BuscarPorID(cajero.IdCajero);

            if (cajeroExistente == null)
            {
                return "El cajero no existe.";
            }

            string? error = ValidarDatos(cajero);

            if (error != null)
            {
                return error;
            }

            Cajero? cajeroConMismaIdentificacion =
                cajeroAD.BuscarPorIdentificacion(
                    cajero.Identificacion);

            if (
                cajeroConMismaIdentificacion != null
                &&
                cajeroConMismaIdentificacion.IdCajero
                    != cajero.IdCajero
            )
            {
                return "La identificación ya pertenece a otro cajero.";
            }

            if (!cajeroAD.Actualizar(cajero))
            {
                return "No se pudo actualizar el cajero.";
            }

            return null;
        }
    }
}