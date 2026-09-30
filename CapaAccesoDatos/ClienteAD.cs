using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class ClienteAD
    {
        private static Cliente[] clientes = new Cliente[50];
        private static int contador = 0;

        public bool Agregar(Cliente cliente)
        {
            if (contador >= clientes.Length)
            {
                return false;
            }

            clientes[contador] = cliente;
            contador++;

            return true;
        }

        public Cliente[] Listar()
        {
            Cliente[] lista = new Cliente[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = clientes[i];
            }

            return lista;
        }

        public Cliente? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].IdCliente == id)
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public Cliente? BuscarPorIdentificacion(string identificacion)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                {
                    return clientes[i];
                }
            }

            return null;
        }

        public bool Actualizar(Cliente cliente)
        {
            Cliente? existente =
                BuscarPorID(cliente.IdCliente);

            if (existente == null)
            {
                return false;
            }

            existente.Identificacion =
                cliente.Identificacion;

            existente.Nombre =
                cliente.Nombre;

            existente.Apellido =
                cliente.Apellido;

            existente.FechaNacimiento =
                cliente.FechaNacimiento;

            existente.FechaRegistro =
                cliente.FechaRegistro;

            existente.Activo =
                cliente.Activo;

            return true;
        }
    }
}