using CapaAccesoDatos;
using CapaEntidad;

namespace CapaLogicaNegocios
{
    public class VentaLN
    {
        private VentaAD ventaAD = new();
        private ClienteAD clienteAD = new();
        private CajeroAD cajeroAD = new();
        private ProduccionAD produccionAD = new();

        public string? Registrar(
            int idVenta,
            int idCliente,
            int idCajero,
            int idProduccion,
            int cantidad,
            DateTime fechaVenta)
        {
            try
            {
                if (ventaAD.BuscarPorID(idVenta) != null)
                {
                    return "El ID de venta ya existe.";
                }

            Cliente? cliente =
                clienteAD.BuscarPorID(idCliente);

            if (cliente == null)
            {
                return "El cliente no existe.";
            }

            if (!cliente.Activo)
            {
                return "El cliente está inactivo.";
            }

            Cajero? cajero =
                cajeroAD.BuscarPorID(idCajero);

            if (cajero == null)
            {
                return "El cajero no existe.";
            }

            Produccion? produccion =
                produccionAD.BuscarPorID(idProduccion);

            if (produccion == null)
            {
                return "La producción no existe.";
            }

            if (!produccion.Producto.Activo)
            {
                return "El producto asociado está inactivo.";
            }

            if (produccion.CantidadDisponible <= 0)
            {
                return "La producción no tiene unidades disponibles.";
            }

            if (cantidad <= 0)
            {
                return "La cantidad debe ser mayor que cero.";
            }

            if (cantidad > produccion.CantidadDisponible)
            {
                return "No hay suficiente cantidad disponible para realizar la venta.";
            }

            if (fechaVenta.Date > DateTime.Today)
            {
                return "La fecha de venta no puede ser mayor al día actual.";
            }

            decimal subTotal =
                cantidad * produccion.Producto.PrecioVenta;

            decimal impuesto =
                subTotal * 0.13m;

            decimal totalVenta =
                subTotal + impuesto;

            Venta venta = new(
                idVenta,
                cliente,
                cajero,
                produccion,
                cantidad,
                fechaVenta,
                subTotal,
                impuesto,
                totalVenta
            );
            if (!ventaAD.Agregar(venta))
            {
                return "No hay espacio para registrar más ventas.";
            }

            // Only deduct availability after the sale has been recorded
            produccion.CantidadDisponible -= cantidad;

            return null;
        }
            catch (Exception ex)
            {
                return $"Se produjo un error inesperado: {ex.Message}";
            }
        }

        public Venta? BuscarPorID(int id)
        {
            return ventaAD.BuscarPorID(id);
        }

        public Venta[] Listar()
        {
            return ventaAD.Listar();
        }

        public Cliente[] ListarClientes()
        {
            return clienteAD.Listar();
        }

        public Cajero[] ListarCajeros()
        {
            return cajeroAD.Listar();
        }

        public Produccion[] ListarProducciones()
        {
            return produccionAD.Listar();
        }
    }
}