namespace CapaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public Cliente Cliente { get; set; }
        public Cajero Cajero { get; set; }
        public Produccion Produccion { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Impuesto { get; set; }
        public decimal TotalVenta { get; set; }
        public string TipoVenta { get; set; }

        public Venta(
            int idVenta,
            Cliente cliente,
            Cajero cajero,
            Produccion produccion,
            int cantidad,
            DateTime fechaVenta,
            decimal subTotal,
            decimal impuesto,
            decimal totalVenta)
        {
            IdVenta = idVenta;
            Cliente = cliente;
            Cajero = cajero;
            Produccion = produccion;
            Cantidad = cantidad;
            FechaVenta = fechaVenta;
            SubTotal = subTotal;
            Impuesto = impuesto;
            TotalVenta = totalVenta;
            TipoVenta = "Interna";
        }
    }
}