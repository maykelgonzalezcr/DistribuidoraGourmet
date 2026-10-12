using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Globalization;
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

            // Establecer máximo para cantidad de venta acorde a int
            nudCantidad.Maximum = new decimal(int.MaxValue);

            _ventaLN = ventaLN;

            CargarClientes();
            CargarCajeros();
            CargarProducciones();
            CargarVentas();
            // Wire data-binding complete handler to populate nested property columns
            dgvVentas.DataBindingComplete -= DgvVentas_DataBindingComplete;
            dgvVentas.DataBindingComplete += DgvVentas_DataBindingComplete;

            // Wire UI handlers to keep cálculos actualizados y limitar cantidad
            cmbProduccion.SelectedIndexChanged -= cmbProduccion_SelectedIndexChanged;
            cmbProduccion.SelectedIndexChanged += cmbProduccion_SelectedIndexChanged;

            nudCantidad.ValueChanged -= nudCantidad_ValueChanged;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;

            txtTipoVenta.Text = "Interna";
            this.MinimumSize = new System.Drawing.Size(800, 600);
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

            // Configurar columnas sólo la primera vez para mantener consistencia
            if (dgvVentas.Columns.Count == 0)
            {
                void AddCol(string name, string header, string dataProp = "", string format = "", int width = 100, DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft)
                {
                    var c = new DataGridViewTextBoxColumn();
                    c.DataPropertyName = dataProp;
                    c.Name = name;
                    c.HeaderText = header;
                    c.Width = width;
                    c.DefaultCellStyle.Alignment = align;
                    if (!string.IsNullOrEmpty(format)) c.DefaultCellStyle.Format = format;
                    dgvVentas.Columns.Add(c);
                }

                AddCol("IdVenta", "IdVenta", "IdVenta", "", 70, DataGridViewContentAlignment.MiddleCenter);
                AddCol("ClienteNombre", "Cliente (Nombre)", "", "", 140, DataGridViewContentAlignment.MiddleLeft);
                AddCol("CajeroNombre", "Cajero (Nombre)", "", "", 140, DataGridViewContentAlignment.MiddleLeft);
                AddCol("ProductoNombre", "Producto (Nombre)", "", "", 150, DataGridViewContentAlignment.MiddleLeft);
                AddCol("Cantidad", "Cantidad", "Cantidad", "", 80, DataGridViewContentAlignment.MiddleRight);
                AddCol("FechaVenta", "FechaVenta", "FechaVenta", "d", 100, DataGridViewContentAlignment.MiddleCenter);
                AddCol("SubTotal", "SubTotal", "SubTotal", "N2", 110, DataGridViewContentAlignment.MiddleRight);
                AddCol("Impuesto", "Impuesto", "Impuesto", "N2", 110, DataGridViewContentAlignment.MiddleRight);
                AddCol("TotalVenta", "TotalVenta", "TotalVenta", "N2", 110, DataGridViewContentAlignment.MiddleRight);
            }

            // Asignar DataSource después de crear columnas para que el binding funcione para propiedades anidadas
            dgvVentas.DataSource = _ventaLN.Listar();

            // No usar AutoSizeColumnsMode.Fill para mantener los anchos configurados
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void DgvVentas_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            var lista = _ventaLN.Listar();
            if (lista == null) return;

            for (int i = 0; i < dgvVentas.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvVentas.Rows[i];
                if (fila.IsNewRow) continue;
                if (fila.DataBoundItem is Venta v)
                {
                    // Expected columns: 0=IdVenta, 1=ClienteNombre, 2=CajeroNombre, 3=ProductoNombre, 4=Cantidad, 5=FechaVenta, 6=SubTotal, 7=Impuesto, 8=TotalVenta

                    // Cliente Nombre
                    if (dgvVentas.Columns.Contains("ClienteNombre"))
                    {
                        fila.Cells[dgvVentas.Columns["ClienteNombre"].Index].Value = v.Cliente != null ? $"{v.Cliente.Nombre} {v.Cliente.Apellido}" : string.Empty;
                    }

                    // Cajero Nombre
                    if (dgvVentas.Columns.Contains("CajeroNombre"))
                    {
                        fila.Cells[dgvVentas.Columns["CajeroNombre"].Index].Value = v.Cajero != null ? $"{v.Cajero.Nombre} {v.Cajero.Apellido}" : string.Empty;
                    }

                    // Producto Nombre
                    if (dgvVentas.Columns.Contains("ProductoNombre"))
                    {
                        fila.Cells[dgvVentas.Columns["ProductoNombre"].Index].Value = v.Produccion != null && v.Produccion.Producto != null
                            ? v.Produccion.Producto.NombreProducto
                            : string.Empty;
                    }

                    // Ensure numeric values are assigned to currency columns; formatting handled by column DefaultCellStyle.Format
                    if (dgvVentas.Columns.Contains("SubTotal"))
                    {
                        fila.Cells[dgvVentas.Columns["SubTotal"].Index].Value = v.SubTotal;
                    }
                    if (dgvVentas.Columns.Contains("Impuesto"))
                    {
                        fila.Cells[dgvVentas.Columns["Impuesto"].Index].Value = v.Impuesto;
                    }
                    if (dgvVentas.Columns.Contains("TotalVenta"))
                    {
                        fila.Cells[dgvVentas.Columns["TotalVenta"].Index].Value = v.TotalVenta;
                    }
                }
            }

            dgvVentas.Refresh();
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

        // Event handler stubs wired by the Designer. Kept minimal to avoid
        // changing UI behavior while resolving Designer/compile errors.
        private void txtIdVenta_TextChanged(object sender, EventArgs e)
        {
            // Intentionally left blank (Designer wiring requires this method).
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Intentionally left blank.
        }

        private void cmbCajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Intentionally left blank.
        }

        private void cmbProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Al cambiar la producción seleccionada, ajustar el máximo de cantidad
            // y recalcular totales según la producción y la cantidad actual.
            if (cmbProduccion.SelectedItem is Produccion p)
            {
                // Establecer máximo acorde a la disponibilidad de la producción seleccionada
                nudCantidad.Maximum = new decimal(p.CantidadDisponible);

                // Si la cantidad actual excede la nueva máxima, ajustarla
                if (nudCantidad.Value > nudCantidad.Maximum)
                {
                    nudCantidad.Value = nudCantidad.Maximum;
                }

                // Recalcular totales usando la cantidad actual
                int cantidad = Convert.ToInt32(nudCantidad.Value);
                decimal sub = cantidad * p.Producto.PrecioVenta;
                decimal imp = sub * 0.13m;
                txtSubTotal.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotalVenta.Text = (sub + imp).ToString("C2");
            }
            else
            {
                // Si no hay producción seleccionada, permitir el máximo genérico y limpiar totales
                nudCantidad.Maximum = new decimal(int.MaxValue);
                txtSubTotal.Clear();
                txtImpuesto.Clear();
                txtTotalVenta.Clear();
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            // Recalcular SubTotal, Impuesto y Total en base a la producción seleccionada
            if (cmbProduccion.SelectedItem is Produccion p)
            {
                int cantidad = Convert.ToInt32(nudCantidad.Value);
                // Asegurar que no exceda la disponibilidad (por si se cambia programáticamente)
                if (cantidad > p.CantidadDisponible)
                {
                    nudCantidad.Value = new decimal(p.CantidadDisponible);
                    cantidad = p.CantidadDisponible;
                }

                decimal sub = cantidad * p.Producto.PrecioVenta;
                decimal imp = sub * 0.13m;
                txtSubTotal.Text = sub.ToString("C2");
                txtImpuesto.Text = imp.ToString("C2");
                txtTotalVenta.Text = (sub + imp).ToString("C2");
            }
            else
            {
                txtSubTotal.Clear();
                txtImpuesto.Clear();
                txtTotalVenta.Clear();
            }
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

            // Select cliente/cajero/produccion by matching IDs (SelectedItem by reference fails when data sources are new instances)
            if (venta.Cliente != null)
            {
                for (int i = 0; i < cmbCliente.Items.Count; i++)
                {
                    if (cmbCliente.Items[i] is Cliente c && c.IdCliente == venta.Cliente.IdCliente)
                    {
                        cmbCliente.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (venta.Cajero != null)
            {
                for (int i = 0; i < cmbCajero.Items.Count; i++)
                {
                    if (cmbCajero.Items[i] is Cajero caj && caj.IdCajero == venta.Cajero.IdCajero)
                    {
                        cmbCajero.SelectedIndex = i;
                        break;
                    }
                }
            }

            if (venta.Produccion != null)
            {
                for (int i = 0; i < cmbProduccion.Items.Count; i++)
                {
                    if (cmbProduccion.Items[i] is Produccion p && p.IdProduccion == venta.Produccion.IdProduccion)
                    {
                        cmbProduccion.SelectedIndex = i;
                        break;
                    }
                }
            }

            // Ensure NumericUpDown range matches available stock and assign the stored quantity
            nudCantidad.Minimum = Math.Min(nudCantidad.Minimum, 0);
            nudCantidad.Maximum = decimal.MaxValue;
            nudCantidad.Value = venta.Cantidad;
            dtpFechaVenta.Value = venta.FechaVenta.Date;

            // Use culture-aware currency formatting (Program sets default culture to es-CR)
            txtSubTotal.Text = venta.SubTotal.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
            txtImpuesto.Text = venta.Impuesto.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
            txtTotalVenta.Text = venta.TotalVenta.ToString("N2", System.Globalization.CultureInfo.CurrentCulture);
            txtTipoVenta.Text = venta.TipoVenta;

            txtIdVenta.Enabled = false;
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // User selected: disable all DataGridView click behavior — do nothing when a row is clicked.
            // This prevents crashes and avoids loading any data from the grid into the form.
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
