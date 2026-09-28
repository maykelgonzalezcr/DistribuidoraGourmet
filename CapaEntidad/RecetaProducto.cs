using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class RecetaProducto
    {
        public int IdRecetaProducto { get; set; }
        public Producto Producto { get; set; }
        public Ingrediente Ingrediente { get; set; }
        public decimal CantidadRequerida { get; set; }

        public RecetaProducto(
            int idRecetaProducto,
            Producto producto,
            Ingrediente ingrediente,
            decimal cantidadRequerida)
        {
            IdRecetaProducto = idRecetaProducto;
            Producto = producto;
            Ingrediente = ingrediente;
            CantidadRequerida = cantidadRequerida;
        }
    }
}