using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public abstract class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        protected Persona(
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public abstract string ObtenerDescripcion();
    }
}