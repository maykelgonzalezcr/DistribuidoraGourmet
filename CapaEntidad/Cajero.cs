using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Cajero : Persona
    {
        public int IdCajero { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Cajero(
            int idCajero,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaIngreso)
            : base(
                identificacion,
                nombre,
                apellido,
                fechaNacimiento)
        {
            IdCajero = idCajero;
            FechaIngreso = fechaIngreso;
        }

        public override string ObtenerDescripcion()
        {
            return $"{NombreCompleto()} - " +
                   $"Ingreso: {FechaIngreso:d}";
        }
    }
}