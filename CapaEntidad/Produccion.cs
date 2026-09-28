using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidad
{
    public class Produccion
    {
        public int IdProduccion { get; set; }
        public Producto Producto { get; set; }
        public int CantidadProducida { get; set; }
        public DateTime FechaProduccion { get; set; }
        public decimal CostoProduccion { get; set; }
        public int CantidadDisponible { get; set; }

        public Produccion(
            int idProduccion,
            Producto producto,
            int cantidadProducida,
            DateTime fechaProduccion,
            decimal costoProduccion)
        {
            IdProduccion = idProduccion;
            Producto = producto;
            CantidadProducida = cantidadProducida;
            FechaProduccion = fechaProduccion;
            CostoProduccion = costoProduccion;
            CantidadDisponible = cantidadProducida;
        }
    }
}