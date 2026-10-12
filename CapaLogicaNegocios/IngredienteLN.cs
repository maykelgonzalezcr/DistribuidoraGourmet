using System;
using System.Collections.Generic;
using System.Text;
using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class IngredienteLN
    {
        private IngredienteAD ingredienteAD = new();

        private string? ValidarDatos(Ingrediente ingrediente)
        {

            if (string.IsNullOrWhiteSpace(ingrediente.NombreIngrediente))
            {
                return "El nombre del ingrediente no puede estar vacio.";
            }

            if (string.IsNullOrWhiteSpace(ingrediente.UnidadMedida))
            {
                return "La unidad de medida no puede estar vacía.";
            }

            if (ingrediente.ExistenciaActual < 0)
            {
                return "La existencia actual no puede ser negativa.";
            }

            if (ingrediente.CostoUnitario <= 0)
            {
                return "El costo unitario debe ser mayor que cero.";
            }

            return null;
        }

        public string? Registrar(Ingrediente ingrediente)
        {
            if (ingredienteAD.BuscarPorID(ingrediente.IdIngrediente) != null)
            {
                return "El ID del ingrediente ya existe.";
            }

            string? error = ValidarDatos(ingrediente);

            if (error != null)
            {
                return error;
            }

            if (!ingredienteAD.Agregar(ingrediente))
            {
                return "No hay espacio para registrar más ingredientes.";
            }

            return null;
        }

        public Ingrediente[] Listar()
        {
            return ingredienteAD.Listar();
        }

        public string? Actualizar(Ingrediente ingrediente)
        {
            if (ingredienteAD.BuscarPorID(ingrediente.IdIngrediente) == null)
            {
                return "El ingrediente no existe.";
            }

            string? error = ValidarDatos(ingrediente);

            if (error != null)
            {
                return error;
            }

            if (!ingredienteAD.Actualizar(ingrediente))
            {
                return "No se pudo actualizar el ingrediente.";
            }

            return null;
        }

        public Ingrediente? BuscarPorID(int id)
        {
            return ingredienteAD.BuscarPorID(id);
        }
    }
}
