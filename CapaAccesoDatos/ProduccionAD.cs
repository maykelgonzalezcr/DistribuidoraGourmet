using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class ProduccionAD
    {
        private Produccion[] producciones = new Produccion[200];
        private int contador = 0;

        public bool Agregar(Produccion produccion)
        {
            if (contador >= producciones.Length)
            {
                return false;
            }

            producciones[contador] = produccion;
            contador++;

            return true;
        }

        public Produccion[] Listar()
        {
            Produccion[] lista = new Produccion[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = producciones[i];
            }

            return lista;
        }

        public Produccion? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (producciones[i].IdProduccion == id)
                {
                    return producciones[i];
                }
            }

            return null;
        }

        public bool Actualizar(Produccion produccion)
        {
            Produccion? existente =
                BuscarPorID(produccion.IdProduccion);

            if (existente == null)
            {
                return false;
            }

            existente.Producto = produccion.Producto;
            existente.CantidadProducida =
                produccion.CantidadProducida;
            existente.FechaProduccion =
                produccion.FechaProduccion;
            existente.CostoProduccion =
                produccion.CostoProduccion;
            existente.CantidadDisponible =
                produccion.CantidadDisponible;

            return true;
        }
    }
}