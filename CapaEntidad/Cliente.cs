using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public Cliente(
            int idCliente,
            string identificacion,
            string nombre,
            string apellido,
            DateTime fechaNacimiento,
            DateTime fechaRegistro,
            bool activo = true)
            : base(
                identificacion,
                nombre,
                apellido,
                fechaNacimiento)
        {
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public override string ObtenerDescripcion()
        {
            return $"{NombreCompleto()} - " +
                   $"{(Activo ? "Activo" : "Inactivo")}";
        }
    }
}