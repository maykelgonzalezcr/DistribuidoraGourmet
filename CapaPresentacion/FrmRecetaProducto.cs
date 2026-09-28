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
    public partial class FrmRecetaProducto : Form
    {
        private RecetaProductoLN _recetaProductoLN;

        public FrmRecetaProducto(RecetaProductoLN recetaProductoLN)
        {
            InitializeComponent();

            _recetaProductoLN = recetaProductoLN;

            CargarProductos();
            CargarIngredientes();
            CargarRecetas();
        }

        private void CargarProductos()
        {
            Producto[] productos = _recetaProductoLN.ListarProductos();

            cmbProducto.DataSource = null;
            cmbProducto.DataSource = productos;
            cmbProducto.DisplayMember = "NombreProducto";
            cmbProducto.ValueMember = "IdProducto";
            cmbProducto.SelectedIndex = -1;
        }

        private void CargarIngredientes()
        {
            Ingrediente[] ingredientes = _recetaProductoLN.ListarIngredientes();

            cmbIngrediente.DataSource = null;
            cmbIngrediente.DataSource = ingredientes;
            cmbIngrediente.DisplayMember = "NombreIngrediente";
            cmbIngrediente.ValueMember = "IdIngrediente";
            cmbIngrediente.SelectedIndex = -1;
        }

        private void CargarRecetas()
        {
            dgvRecetas.AutoGenerateColumns = false;
            dgvRecetas.DataSource = _recetaProductoLN.Listar();

            if (dgvRecetas.Columns.Count == 0)
            {
                DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdRecetaProducto";
                colId.HeaderText = "ID";
                dgvRecetas.Columns.Add(colId);

                DataGridViewTextBoxColumn colProducto = new DataGridViewTextBoxColumn();
                colProducto.DataPropertyName = "Producto.NombreProducto";
                colProducto.HeaderText = "Producto";
                dgvRecetas.Columns.Add(colProducto);

                DataGridViewTextBoxColumn colIngrediente = new DataGridViewTextBoxColumn();
                colIngrediente.DataPropertyName = "Ingrediente.NombreIngrediente";
                colIngrediente.HeaderText = "Ingrediente";
                dgvRecetas.Columns.Add(colIngrediente);

                DataGridViewTextBoxColumn colCantidad = new DataGridViewTextBoxColumn();
                colCantidad.DataPropertyName = "CantidadRequerida";
                colCantidad.HeaderText = "Cantidad Requerida";
                dgvRecetas.Columns.Add(colCantidad);
            }
        }

        private void LimpiarCampos()
        {
            txtIdRecetaProducto.Clear();
            cmbProducto.SelectedIndex = -1;
            cmbIngrediente.SelectedIndex = -1;
            nudCantidadRequerida.Value = nudCantidadRequerida.Minimum;
            txtIdRecetaProducto.Enabled = true;
            txtIdRecetaProducto.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdRecetaProducto.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            if (cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto.");
                return;
            }

            if (cmbIngrediente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un ingrediente.");
                return;
            }

            int idProducto = Convert.ToInt32(cmbProducto.SelectedValue);
            int idIngrediente = Convert.ToInt32(cmbIngrediente.SelectedValue);

            string? error = _recetaProductoLN.Registrar(
                id,
                idProducto,
                idIngrediente,
                nudCantidadRequerida.Value
            );

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Receta registrada correctamente.");
            CargarRecetas();
            LimpiarCampos();
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdRecetaProducto.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            RecetaProducto? receta = _recetaProductoLN.BuscarPorID(id);

            if (receta == null)
            {
                MessageBox.Show("No se encontró una receta con ese ID.");
                return;
            }

            txtIdRecetaProducto.Text = receta.IdRecetaProducto.ToString();
            // select producto and ingrediente in comboboxes by value
            CargarProductos();
            CargarIngredientes();
            cmbProducto.SelectedValue = receta.Producto.IdProducto;
            cmbIngrediente.SelectedValue = receta.Ingrediente.IdIngrediente;
            nudCantidadRequerida.Value = receta.CantidadRequerida;

            txtIdRecetaProducto.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvRecetas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvRecetas.Rows[e.RowIndex];

            txtIdRecetaProducto.Text = fila.Cells[0].Value.ToString();
            int id = Convert.ToInt32(fila.Cells[0].Value);

            RecetaProducto? receta = _recetaProductoLN.BuscarPorID(id);

            if (receta == null)
            {
                return;
            }

            CargarProductos();
            CargarIngredientes();
            cmbProducto.SelectedValue = receta.Producto.IdProducto;
            cmbIngrediente.SelectedValue = receta.Ingrediente.IdIngrediente;
            nudCantidadRequerida.Value = receta.CantidadRequerida;

            txtIdRecetaProducto.Enabled = false;
        }
    }
}
