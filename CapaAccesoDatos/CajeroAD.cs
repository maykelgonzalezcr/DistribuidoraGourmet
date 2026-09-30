using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class CajeroAD
    {
        private static Cajero[] cajeros = new Cajero[15];
        private static int contador = 0;

        public bool Agregar(Cajero cajero)
        {
            if (contador >= cajeros.Length)
            {
                return false;
            }

            cajeros[contador] = cajero;
            contador++;

            return true;
        }

        public Cajero[] Listar()
        {
            Cajero[] lista = new Cajero[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = cajeros[i];
            }

            return lista;
        }

        public Cajero? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (cajeros[i].IdCajero == id)
                {
                    return cajeros[i];
                }
            }

            return null;
        }

        public Cajero? BuscarPorIdentificacion(string identificacion)
        {
            for (int i = 0; i < contador; i++)
            {
                if (cajeros[i].Identificacion == identificacion)
                {
                    return cajeros[i];
                }
            }

            return null;
        }

        public bool Actualizar(Cajero cajero)
        {
            Cajero? existente =
                BuscarPorID(cajero.IdCajero);

            if (existente == null)
            {
                return false;
            }

            existente.Identificacion =
                cajero.Identificacion;

            existente.Nombre =
                cajero.Nombre;

            existente.Apellido =
                cajero.Apellido;

            existente.FechaNacimiento =
                cajero.FechaNacimiento;

            existente.FechaIngreso =
                cajero.FechaIngreso;

            return true;
        }
    }
}