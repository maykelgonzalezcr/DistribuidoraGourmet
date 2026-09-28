using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class RecetaProductoLN
    {
        private RecetaProductoAD recetaProductoAD;
        private ProductoAD productoAD;
        private IngredienteAD ingredienteAD;

        public RecetaProductoLN(
            RecetaProductoAD recetaProductoAD,
            ProductoAD productoAD,
            IngredienteAD ingredienteAD)
        {
            this.recetaProductoAD = recetaProductoAD;
            this.productoAD = productoAD;
            this.ingredienteAD = ingredienteAD;
        }

        private string? ValidarDatos(
            RecetaProducto receta)
        {
            if (receta.CantidadRequerida <= 0)
            {
                return "La cantidad requerida debe ser mayor que cero.";
            }

            return null;
        }

        public string? Registrar(
            int idRecetaProducto,
            int idProducto,
            int idIngrediente,
            decimal cantidadRequerida)
        {
            if (
                recetaProductoAD.BuscarPorID(
                    idRecetaProducto) != null)
            {
                return "El ID de la receta ya existe.";
            }

            Producto? producto =
                productoAD.BuscarPorID(idProducto);

            if (producto == null)
            {
                return "El producto no existe.";
            }

            if (!producto.Activo)
            {
                return "No se puede definir una receta para un producto inactivo.";
            }

            Ingrediente? ingrediente =
                ingredienteAD.BuscarPorID(idIngrediente);

            if (ingrediente == null)
            {
                return "El ingrediente no existe.";
            }

            if (
                recetaProductoAD
                    .BuscarPorProductoEIngrediente(
                        idProducto,
                        idIngrediente) != null)
            {
                return "El ingrediente ya está asociado a este producto.";
            }

            RecetaProducto receta = new(
                idRecetaProducto,
                producto,
                ingrediente,
                cantidadRequerida
            );

            string? error = ValidarDatos(receta);

            if (error != null)
            {
                return error;
            }

            if (!recetaProductoAD.Agregar(receta))
            {
                return "No hay espacio para registrar más recetas.";
            }

            return null;
        }

        public RecetaProducto[] Listar()
        {
            return recetaProductoAD.Listar();
        }

        public Producto[] ListarProductos()
        {
            return productoAD.Listar();
        }

        public Ingrediente[] ListarIngredientes()
        {
            return ingredienteAD.Listar();
        }

        public RecetaProducto? BuscarPorID(int id)
        {
            return recetaProductoAD.BuscarPorID(id);
        }

        public RecetaProducto[] BuscarPorProducto(
            int idProducto)
        {
            return recetaProductoAD
                .BuscarPorProducto(idProducto);
        }
    }
}