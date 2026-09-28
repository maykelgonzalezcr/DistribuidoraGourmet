using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class ProductoLN
    {
        private ProductoAD productoAD;

        public ProductoLN(ProductoAD productoAD)
        {
            this.productoAD = productoAD;
        }

        private string? ValidarDatos(Producto producto)
        {
            if (string.IsNullOrWhiteSpace(
                producto.NombreProducto))
            {
                return "El nombre del producto no puede estar vacío.";
            }

            if (string.IsNullOrWhiteSpace(
                producto.Categoria))
            {
                return "La categoría no puede estar vacía.";
            }

            if (producto.PrecioVenta <= 0)
            {
                return "El precio de venta debe ser mayor que cero.";
            }

            return null;
        }

        public string? Registrar(Producto producto)
        {
            if (productoAD.BuscarPorID(
                producto.IdProducto) != null)
            {
                return "El ID del producto ya existe.";
            }

            string? error = ValidarDatos(producto);

            if (error != null)
            {
                return error;
            }

            if (!productoAD.Agregar(producto))
            {
                return "No hay espacio para registrar más productos.";
            }

            return null;
        }

        public string? Actualizar(Producto producto)
        {
            if (productoAD.BuscarPorID(
                producto.IdProducto) == null)
            {
                return "El producto no existe.";
            }

            string? error = ValidarDatos(producto);

            if (error != null)
            {
                return error;
            }

            if (!productoAD.Actualizar(producto))
            {
                return "No se pudo actualizar el producto.";
            }

            return null;
        }

        public Producto? BuscarPorID(int id)
        {
            return productoAD.BuscarPorID(id);
        }

        public Producto[] Listar()
        {
            return productoAD.Listar();
        }
    }
}