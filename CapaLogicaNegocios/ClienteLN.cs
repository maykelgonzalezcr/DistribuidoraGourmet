using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class ClienteLN
    {
        private ClienteAD clienteAD;

        public ClienteLN(ClienteAD clienteAD)
        {
            this.clienteAD = clienteAD;
        }



        private string? ValidarDatos(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Identificacion))
            {
                return "La identificación no puede estar vacía.";
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                return "El nombre no puede estar vacío.";
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                return "El apellido no puede estar vacío.";
            }

            if (cliente.FechaNacimiento.Date >= DateTime.Today)
            {
                return "La fecha de nacimiento debe ser anterior al día actual.";
            }

            if (cliente.FechaRegistro.Date > DateTime.Today)
            {
                return "La fecha de registro no puede ser mayor al día actual.";
            }

            return null;
        }

        public string? Registrar(Cliente cliente)
        {
            if (clienteAD.BuscarPorID(cliente.IdCliente) != null)
            {
                return "El ID del cliente ya existe.";
            }

            if (clienteAD.BuscarPorIdentificacion(
                cliente.Identificacion) != null)
            {
                return "La identificación del cliente ya existe.";
            }

            string? error = ValidarDatos(cliente);

            if (error != null)
            {
                return error;
            }

            if (!clienteAD.Agregar(cliente))
            {
                return "No hay espacio para registrar más clientes.";
            }

            return null;
        }

        public Cliente? BuscarPorID(int id)
        {
            return clienteAD.BuscarPorID(id);
        }

        public Cliente[] Listar()
        {
            return clienteAD.Listar();
        }

        public string? Actualizar(Cliente cliente)
        {
            Cliente? clienteExistente =
                clienteAD.BuscarPorID(cliente.IdCliente);

            if (clienteExistente == null)
            {
                return "El cliente no existe.";
            }

            string? error = ValidarDatos(cliente);

            if (error != null)
            {
                return error;
            }

            Cliente? clienteConMismaIdentificacion =
                clienteAD.BuscarPorIdentificacion(
                    cliente.Identificacion);

            if (
                clienteConMismaIdentificacion != null
                &&
                clienteConMismaIdentificacion.IdCliente
                    != cliente.IdCliente
            )
            {
                return "La identificación ya pertenece a otro cliente.";
            }

            if (!clienteAD.Actualizar(cliente))
            {
                return "No se pudo actualizar el cliente.";
            }

            return null;
        }
    }
}