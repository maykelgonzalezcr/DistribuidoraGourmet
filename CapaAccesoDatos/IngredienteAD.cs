using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;

namespace CapaAccesoDatos
{
    public class IngredienteAD
    {
        private static Ingrediente[] Ingredientes = new Ingrediente[50];
        private static int contador = 0;
        
        public bool Agregar(Ingrediente ingrediente)
        {
            if (contador < Ingredientes.Length)
            {
                Ingredientes[contador] = ingrediente;
                contador++;
                return true;
            }
            else { return false; }
        }

        public Ingrediente[] Listar()
        {
            Ingrediente[] Lista = new Ingrediente[contador];

            for (int i = 0; i < Lista.Length; i++)
            {
                Lista[i] = Ingredientes[i];
            }

            return Lista;
        }

        public Ingrediente? BuscarPorID(int ID)
        {
            for (int i = 0; i < contador; i++)
            {
                if (Ingredientes[i].IdIngrediente == ID)
                {
                    return Ingredientes[i];
                }
            }

            return null;
        }

        public bool Actualizar(Ingrediente ingrediente)
        {
            Ingrediente? ingredienteExistente = BuscarPorID(ingrediente.IdIngrediente);

            if (ingredienteExistente == null)
            {
                return false;
            }

            ingredienteExistente.NombreIngrediente = ingrediente.NombreIngrediente;
            ingredienteExistente.UnidadMedida = ingrediente.UnidadMedida;
            ingredienteExistente.ExistenciaActual = ingrediente.ExistenciaActual;
            ingredienteExistente.CostoUnitario = ingrediente.CostoUnitario;

            return true;
        }


    }
}
