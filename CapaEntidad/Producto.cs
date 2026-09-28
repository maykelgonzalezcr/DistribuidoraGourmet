using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Activo { get; set; }

        public Producto(
            int idProducto,
            string nombreProducto,
            string categoria,
            decimal precioVenta,
            bool activo = true)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            Categoria = categoria;
            PrecioVenta = precioVenta;
            Activo = activo;
        }
    }
}