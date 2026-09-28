using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class ProductoAD
    {
        private Producto[] productos = new Producto[50];
        private int contador = 0;

        public bool Agregar(Producto producto)
        {
            if (contador >= productos.Length)
            {
                return false;
            }

            productos[contador] = producto;
            contador++;

            return true;
        }

        public Producto[] Listar()
        {
            Producto[] lista = new Producto[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = productos[i];
            }

            return lista;
        }

        public Producto? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (productos[i].IdProducto == id)
                {
                    return productos[i];
                }
            }

            return null;
        }

        public bool Actualizar(Producto producto)
        {
            Producto? productoExistente =
                BuscarPorID(producto.IdProducto);

            if (productoExistente == null)
            {
                return false;
            }

            productoExistente.NombreProducto =
                producto.NombreProducto;

            productoExistente.Categoria =
                producto.Categoria;

            productoExistente.PrecioVenta =
                producto.PrecioVenta;

            productoExistente.Activo =
                producto.Activo;

            return true;
        }
    }
}