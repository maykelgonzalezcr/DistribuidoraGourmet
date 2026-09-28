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

            _produccionLN = produccionLN;

            CargarProductos();
            CargarProducciones();
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
            dgvProducciones.DataSource = _produccionLN.Listar();

            if (dgvProducciones.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdProduccion";
                colId.HeaderText = "ID";
                dgvProducciones.Columns.Add(colId);

                DataGridViewTextBoxColumn colProducto = new DataGridViewTextBoxColumn();
                colProducto.DataPropertyName = "Producto.NombreProducto";
                colProducto.HeaderText = "Producto";
                dgvProducciones.Columns.Add(colProducto);

                DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
                colCantidad.DataPropertyName = "CantidadProducida";
                colCantidad.HeaderText = "Cantidad Producida";
                dgvProducciones.Columns.Add(colCantidad);

                DataGridViewTextBoxColumn colFecha = new DataGridViewTextBoxColumn();
                colFecha.DataPropertyName = "FechaProduccion";
                colFecha.HeaderText = "Fecha Producción";
                dgvProducciones.Columns.Add(colFecha);

                DataGridViewTextBoxColumn colCosto = new DataGridViewTextBoxColumn();
                colCosto.DataPropertyName = "CostoProduccion";
                colCosto.HeaderText = "Costo Producción";
                dgvProducciones.Columns.Add(colCosto);

                DataGridViewTextBoxColumn colDisponible = new DataGridViewTextBoxColumn();
                colDisponible.DataPropertyName = "CantidadDisponible";
                colDisponible.HeaderText = "Cantidad Disponible";
                dgvProducciones.Columns.Add(colDisponible);
            }
        }

        private void LimpiarCampos()
        {
            txtIdProduccion.Clear();
            cmbProducto.SelectedIndex = -1;
            nudCantidadProducida.Value = nudCantidadProducida.Minimum;
            dtpFechaProduccion.Value = DateTime.Today;
            txtIdProduccion.Enabled = true;
            txtIdProduccion.Focus();
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
            CargarProducciones();
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

            txtIdProduccion.Text = fila.Cells[0].Value.ToString();
            int id = Convert.ToInt32(fila.Cells[0].Value);

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
