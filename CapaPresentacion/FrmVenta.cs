using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogicaNegocios;

namespace CapaPresentacion
{
    public partial class FrmVenta : Form
    {
        private VentaLN _ventaLN;

        public FrmVenta(VentaLN ventaLN)
        {
            InitializeComponent();

            _ventaLN = ventaLN;

            CargarClientes();
            CargarCajeros();
            CargarProducciones();
            CargarVentas();

            txtTipoVenta.Text = "Interna";
        }

        private void CargarClientes()
        {
            Cliente[] clientes = _ventaLN.ListarClientes();

            cmbCliente.DataSource = null;
            cmbCliente.DataSource = clientes;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.SelectedIndex = -1;
        }

        private void cmbCliente_Format(object sender, ListControlConvertEventArgs e)
        {
            Cliente c = (Cliente)e.ListItem;
            e.Value = $"{c.Identificacion} - {c.Nombre} {c.Apellido}";
        }

        private void CargarCajeros()
        {
            Cajero[] cajeros = _ventaLN.ListarCajeros();

            cmbCajero.DataSource = null;
            cmbCajero.DataSource = cajeros;
            cmbCajero.FormattingEnabled = true;
            cmbCajero.SelectedIndex = -1;
        }

        private void cmbCajero_Format(object sender, ListControlConvertEventArgs e)
        {
            Cajero c = (Cajero)e.ListItem;
            e.Value = $"{c.Identificacion} - {c.Nombre} {c.Apellido}";
        }

        private void CargarProducciones()
        {
            Produccion[] producciones = _ventaLN.ListarProducciones();

            cmbProduccion.DataSource = null;
            cmbProduccion.DataSource = producciones;
            cmbProduccion.FormattingEnabled = true;
            cmbProduccion.SelectedIndex = -1;
        }

        private void cmbProduccion_Format(object sender, ListControlConvertEventArgs e)
        {
            Produccion p = (Produccion)e.ListItem;
            e.Value = $"{p.IdProduccion} - {p.Producto.NombreProducto} - Disponible: {p.CantidadDisponible}";
        }

        private void CargarVentas()
        {
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.DataSource = _ventaLN.Listar();

            if (dgvVentas.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdVenta";
                colId.HeaderText = "ID";
                dgvVentas.Columns.Add(colId);

                DataGridViewTextBoxColumn colCliente = new DataGridViewTextBoxColumn();
                colCliente.DataPropertyName = "Cliente.Identificacion";
                colCliente.HeaderText = "Cliente";
                dgvVentas.Columns.Add(colCliente);

                DataGridViewTextBoxColumn colCajero = new DataGridViewTextBoxColumn();
                colCajero.DataPropertyName = "Cajero.Identificacion";
                colCajero.HeaderText = "Cajero";
                dgvVentas.Columns.Add(colCajero);

                DataGridViewTextBoxColumn colProducto = new DataGridViewTextBoxColumn();
                colProducto.DataPropertyName = "Produccion.Producto.NombreProducto";
                colProducto.HeaderText = "Producto";
                dgvVentas.Columns.Add(colProducto);

                DataGridViewTextBoxColumn colIdProduccion = new DataGridViewTextBoxColumn();
                colIdProduccion.DataPropertyName = "Produccion.IdProduccion";
                colIdProduccion.HeaderText = "IdProduccion";
                dgvVentas.Columns.Add(colIdProduccion);

                DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
                colCantidad.DataPropertyName = "Cantidad";
                colCantidad.HeaderText = "Cantidad";
                dgvVentas.Columns.Add(colCantidad);

                DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
                colFecha.DataPropertyName = "FechaVenta";
                colFecha.HeaderText = "Fecha Venta";
                dgvVentas.Columns.Add(colFecha);

                DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
                colSub.DataPropertyName = "SubTotal";
                colSub.HeaderText = "SubTotal";
                dgvVentas.Columns.Add(colSub);

                DataGridViewTextBoxColumn colImpuesto = new DataGridViewTextBoxColumn();
                colImpuesto.DataPropertyName = "Impuesto";
                colImpuesto.HeaderText = "Impuesto";
                dgvVentas.Columns.Add(colImpuesto);

                DataGridViewTextBoxColumn colTotal = new DataGridViewTextBoxColumn();
                colTotal.DataPropertyName = "TotalVenta";
                colTotal.HeaderText = "Total";
                dgvVentas.Columns.Add(colTotal);

                DataGridViewTextBoxColumn colTipo = new DataGridViewTextBoxColumn();
                colTipo.DataPropertyName = "TipoVenta";
                colTipo.HeaderText = "Tipo";
                dgvVentas.Columns.Add(colTipo);
            }
        }

        private void LimpiarCampos()
        {
            txtIdVenta.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbCajero.SelectedIndex = -1;
            cmbProduccion.SelectedIndex = -1;
            nudCantidad.Value = nudCantidad.Minimum;
            dtpFechaVenta.Value = DateTime.Today;
            txtSubTotal.Clear();
            txtImpuesto.Clear();
            txtTotalVenta.Clear();
            txtTipoVenta.Text = "Interna";
            txtIdVenta.Enabled = true;
            txtIdVenta.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdVenta.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            if (cmbCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente.");
                return;
            }

            if (cmbCajero.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cajero.");
                return;
            }

            if (cmbProduccion.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una producción.");
                return;
            }

            int idCliente = ((Cliente)cmbCliente.SelectedItem).IdCliente;
            int idCajero = ((Cajero)cmbCajero.SelectedItem).IdCajero;
            int idProduccion = ((Produccion)cmbProduccion.SelectedItem).IdProduccion;
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            DateTime fecha = dtpFechaVenta.Value.Date;

            string? error = _ventaLN.Registrar(
                id,
                idCliente,
                idCajero,
                idProduccion,
                cantidad,
                fecha
            );

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Venta registrada correctamente.");
            CargarVentas();
            CargarProducciones();
            LimpiarCampos();
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdVenta.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Venta? venta = _ventaLN.BuscarPorID(id);

            if (venta == null)
            {
                MessageBox.Show("No se encontró una venta con ese ID.");
                return;
            }

            txtIdVenta.Text = venta.IdVenta.ToString();
            CargarClientes();
            CargarCajeros();
            CargarProducciones();
            cmbCliente.SelectedItem = venta.Cliente;
            cmbCajero.SelectedItem = venta.Cajero;
            cmbProduccion.SelectedItem = venta.Produccion;
            nudCantidad.Value = venta.Cantidad;
            dtpFechaVenta.Value = venta.FechaVenta.Date;
            txtSubTotal.Text = venta.SubTotal.ToString("C2");
            txtImpuesto.Text = venta.Impuesto.ToString("C2");
            txtTotalVenta.Text = venta.TotalVenta.ToString("C2");
            txtTipoVenta.Text = venta.TipoVenta;

            txtIdVenta.Enabled = false;
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvVentas.Rows[e.RowIndex];

            int id = Convert.ToInt32(fila.Cells[0].Value);

            Venta? venta = _ventaLN.BuscarPorID(id);

            if (venta == null)
            {
                return;
            }

            txtIdVenta.Text = venta.IdVenta.ToString();
            CargarClientes();
            CargarCajeros();
            CargarProducciones();
            cmbCliente.SelectedItem = venta.Cliente;
            cmbCajero.SelectedItem = venta.Cajero;
            cmbProduccion.SelectedItem = venta.Produccion;
            nudCantidad.Value = venta.Cantidad;
            dtpFechaVenta.Value = venta.FechaVenta.Date;
            txtSubTotal.Text = venta.SubTotal.ToString("C2");
            txtImpuesto.Text = venta.Impuesto.ToString("C2");
            txtTotalVenta.Text = venta.TotalVenta.ToString("C2");
            txtTipoVenta.Text = venta.TipoVenta;

            txtIdVenta.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
