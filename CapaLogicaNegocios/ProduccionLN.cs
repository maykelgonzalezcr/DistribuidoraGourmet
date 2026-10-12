using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class ProduccionLN
    {
        private ProduccionAD produccionAD = new();
        private ProductoAD productoAD = new();
        private RecetaProductoAD recetaProductoAD = new();
        private IngredienteAD ingredienteAD = new();

        public string? Registrar(
            int idProduccion,
            int idProducto,
            int cantidadProducida,
            DateTime fechaProduccion)
        {
            try
            {
            if (produccionAD.BuscarPorID(idProduccion) != null)
            {
                return "El ID de producción ya existe.";
            }

            Producto? producto =
                productoAD.BuscarPorID(idProducto);

            if (producto == null)
            {
                return "El producto no existe.";
            }

            if (!producto.Activo)
            {
                return "No se puede producir un producto inactivo.";
            }

            if (cantidadProducida <= 0)
            {
                return "La cantidad producida debe ser mayor que cero.";
            }

            if (fechaProduccion.Date > DateTime.Today)
            {
                return "La fecha de producción no puede ser mayor al día actual.";
            }

            RecetaProducto[] recetas =
                recetaProductoAD.BuscarPorProducto(idProducto);

            if (recetas.Length == 0)
            {
                return "El producto no tiene una receta registrada.";
            }

            decimal costoProduccion = 0;

            // Primero validar TODOS los ingredientes y calcular el costo total
            for (int i = 0; i < recetas.Length; i++)
            {
                RecetaProducto receta = recetas[i];

                decimal cantidadNecesaria =
                    receta.CantidadRequerida * cantidadProducida;

                if (receta.Ingrediente.ExistenciaActual < cantidadNecesaria)
                {
                    return $"No hay suficiente existencia de {receta.Ingrediente.NombreIngrediente}.";
                }

                costoProduccion +=
                    cantidadNecesaria *
                    receta.Ingrediente.CostoUnitario;
            }

            // Crear la producción pero no modificar inventario todavía
            Produccion produccion = new(
                idProduccion,
                producto,
                cantidadProducida,
                fechaProduccion,
                costoProduccion
            );

            // Intentar agregar la producción al almacenamiento. Solo si se
            // agrega correctamente procedemos a deducir los ingredientes.
            if (!produccionAD.Agregar(produccion))
            {
                return "No hay espacio para registrar más producciones.";
            }

            // Ahora que la producción fue registrada, descontar los ingredientes
            for (int i = 0; i < recetas.Length; i++)
            {
                RecetaProducto receta = recetas[i];

                decimal cantidadNecesaria =
                    receta.CantidadRequerida * cantidadProducida;

                receta.Ingrediente.ExistenciaActual -= cantidadNecesaria;
            }

            return null;
            }
            catch (Exception ex)
            {
                return $"Se produjo un error inesperado: {ex.Message}";
            }
        }

        public Produccion? BuscarPorID(int id)
        {
            return produccionAD.BuscarPorID(id);
        }

        public Produccion[] Listar()
        {
            return produccionAD.Listar();
        }

        public Producto[] ListarProductos()
        {
            return productoAD.Listar();
        }
    }
}