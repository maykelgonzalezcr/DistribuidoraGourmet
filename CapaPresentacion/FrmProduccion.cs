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
    public partial class FrmProduccion : Form
    {
        private ProduccionLN _produccionLN;

        public FrmProduccion(ProduccionLN produccionLN)
        {
            InitializeComponent();

            // Establecer máximo para cantidad producida acorde a int
            nudCantidadProducida.Maximum = new decimal(int.MaxValue);

            _produccionLN = produccionLN;

            CargarProductos();
            CargarProducciones();
            // Wire DataBindingComplete to fill Producto cell (column is unbound)
            dgvProducciones.DataBindingComplete -= DgvProducciones_DataBindingComplete;
            dgvProducciones.DataBindingComplete += DgvProducciones_DataBindingComplete;
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void CargarProductos()
        {
            Producto[] productos = _produccionLN.ListarProductos();

            cmbProducto.DataSource = null;
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void CargarProducciones()
        {
            dgvProducciones.AutoGenerateColumns = false;

            if (dgvProducciones.Columns.Count == 0)
            {
                // Build columns matching requested layout:
                // IdProduccion, Producto (Nombre), Producto (PrecioVenta), CantidadProducida, FechaProduccion, CostoProduccion, CantidadDisponible
                void AddCol(string name, string header, string dataProp = "", string format = "", int width = 100, DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft)
                {
                    var c = new DataGridViewTextBoxColumn();
                    c.DataPropertyName = dataProp; // empty for manual fill
                    c.Name = name;
                    c.HeaderText = header;
                    c.Width = width;
                    c.DefaultCellStyle.Alignment = align;
                    if (!string.IsNullOrEmpty(format)) c.DefaultCellStyle.Format = format;
                    dgvProducciones.Columns.Add(c);
                }

                AddCol("IdProduccion", "IdProduccion", "IdProduccion", "", 80, DataGridViewContentAlignment.MiddleCenter);
                AddCol("ProductoNombre", "Producto (Nombre)", "", "", 140, DataGridViewContentAlignment.MiddleLeft);
                AddCol("ProductoPrecioVenta", "Producto (PrecioVenta)", "", "N2", 120, DataGridViewContentAlignment.MiddleRight);
                AddCol("CantidadProducida", "CantidadProducida", "CantidadProducida", "", 120, DataGridViewContentAlignment.MiddleRight);
                AddCol("FechaProduccion", "FechaProduccion", "FechaProduccion", "d", 110, DataGridViewContentAlignment.MiddleCenter);
                AddCol("CostoProduccion", "CostoProduccion", "CostoProduccion", "N2", 120, DataGridViewContentAlignment.MiddleRight);
                AddCol("CantidadDisponible", "CantidadDisponible", "CantidadDisponible", "", 120, DataGridViewContentAlignment.MiddleRight);
            }

            dgvProducciones.DataSource = _produccionLN.Listar();
            dgvProducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void DgvProducciones_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            var lista = _produccionLN.Listar();
            if (lista == null) return;

            for (int i = 0; i < dgvProducciones.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvProducciones.Rows[i];
                if (fila.IsNewRow) continue;
                if (fila.DataBoundItem is Produccion p)
                {
                    // Expected columns: 0=IdProduccion, 1=ProductoNombre, 2=ProductoPrecioVenta, 3=CantidadProducida, 4=FechaProduccion, 5=CostoProduccion, 6=CantidadDisponible
                    if (dgvProducciones.Columns.Count > 1)
                    {
                        fila.Cells[1].Value = p.Producto != null ? p.Producto.NombreProducto : string.Empty;
                    }
                    if (dgvProducciones.Columns.Count > 2)
                    {
                        fila.Cells[2].Value = p.Producto != null ? p.Producto.PrecioVenta : (object)0m;
                    }
                }
            }

            dgvProducciones.Refresh();
        }

        private void LimpiarCampos()
        {
            txtIdProduccion.Clear();
            cmbProducto.SelectedIndex = -1;
            nudCantidadProducida.Value = nudCantidadProducida.Minimum;
            dtpFechaProduccion.Value = DateTime.Today;
            txtIdProduccion.Enabled = true;
            txtIdProduccion.Focus();

            CargarProducciones();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProduccion.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            int cantidad = Convert.ToInt32(nudCantidadProducida.Value);
            DateTime fecha = dtpFechaProduccion.Value.Date;

            string? error = _produccionLN.Registrar(
                id,
                idProducto,
                cantidad,
                fecha
            );

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Producción registrada correctamente.");
            LimpiarCampos();
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProduccion.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Produccion? produccion = _produccionLN.BuscarPorID(id);

            if (produccion == null)
            {
                MessageBox.Show("No se encontró una producción con ese ID.");
                return;
            }

            txtIdProduccion.Text = produccion.IdProduccion.ToString();
            CargarProductos();
            cmbProducto.SelectedValue = produccion.Producto.IdProducto;
            nudCantidadProducida.Value = produccion.CantidadProducida;
            dtpFechaProduccion.Value = produccion.FechaProduccion.Date;

            txtIdProduccion.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProducciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow fila = dgvProducciones.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                return;
            }

            var idCell = fila.Cells[0]?.Value;
            if (idCell == null || !int.TryParse(idCell.ToString(), out int id))
            {
                return;
            }

            txtIdProduccion.Text = id.ToString();

            Produccion? produccion = _produccionLN.BuscarPorID(id);

            if (produccion == null)
            {
                return;
            }

            CargarProductsAndSelect(produccion.Producto.IdProducto);
            nudCantidadProducida.Value = produccion.CantidadProducida;
            dtpFechaProduccion.Value = produccion.FechaProduccion.Date;
            txtIdProduccion.Enabled = false;
        }

        // helper to reload products and select one
        private void CargarProductsAndSelect(int idProducto)
        {
            CargarProductos();
            cmbProducto.SelectedValue = idProducto;
        }
    }
}
