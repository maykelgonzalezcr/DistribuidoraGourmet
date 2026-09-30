using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class RecetaProductoAD
    {
        private static RecetaProducto[] recetas = new RecetaProducto[200];
        private static int contador = 0;

        public bool Agregar(RecetaProducto receta)
        {
            if (contador >= recetas.Length)
            {
                return false;
            }

            recetas[contador] = receta;
            contador++;

            return true;
        }

        public RecetaProducto[] Listar()
        {
            RecetaProducto[] lista =
                new RecetaProducto[contador];

            for (int i = 0; i < contador; i++)
            {
                lista[i] = recetas[i];
            }

            return lista;
        }

        public RecetaProducto? BuscarPorID(int id)
        {
            for (int i = 0; i < contador; i++)
            {
                if (recetas[i].IdRecetaProducto == id)
                {
                    return recetas[i];
                }
            }

            return null;
        }

        public RecetaProducto? BuscarPorProductoEIngrediente(
            int idProducto,
            int idIngrediente)
        {
            for (int i = 0; i < contador; i++)
            {
                if (
                    recetas[i].Producto.IdProducto == idProducto
                    &&
                    recetas[i].Ingrediente.IdIngrediente == idIngrediente
                )
                {
                    return recetas[i];
                }
            }

            return null;
        }

        public RecetaProducto[] BuscarPorProducto(int idProducto)
        {
            int cantidad = 0;

            for (int i = 0; i < contador; i++)
            {
                if (recetas[i].Producto.IdProducto == idProducto)
                {
                    cantidad++;
                }
            }

            RecetaProducto[] resultado =
                new RecetaProducto[cantidad];

            int indice = 0;

            for (int i = 0; i < contador; i++)
            {
                if (recetas[i].Producto.IdProducto == idProducto)
                {
                    resultado[indice] = recetas[i];
                    indice++;
                }
            }

            return resultado;
        }

        public bool Actualizar(RecetaProducto receta)
        {
            RecetaProducto? existente =
                BuscarPorID(receta.IdRecetaProducto);

            if (existente == null)
            {
                return false;
            }

            existente.Producto = receta.Producto;
            existente.Ingrediente = receta.Ingrediente;
            existente.CantidadRequerida =
                receta.CantidadRequerida;

            return true;
        }
    }
}