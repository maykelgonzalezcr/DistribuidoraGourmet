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
    public partial class FrmProducto : Form
    {
        private ProductoLN _productoLN;
        public FrmProducto(ProductoLN productoLN)
        {
            InitializeComponent();

            // Establecer máximo para precio según el tipo decimal
            nudPrecioVenta.Maximum = decimal.MaxValue;
            this._productoLN = productoLN;
            chkActivo.Checked = true;
            CargarProductos();
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Producto Producto = new(
                id,
                txtNombreProducto.Text,
                txtCategoria.Text,
                nudPrecioVenta.Value,
                chkActivo.Checked
                );

            string? error = _productoLN.Registrar(Producto);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Producto registrado correctamente.");
            CargarProductos();
            LimpiarCampos();

        }

        private void CargarProductos()
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = _productoLN.Listar();

            if (dgvProductos.Columns.Count == 0)
            {
                dgvProductos.Columns.Clear();

                var colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdProducto";
                colId.HeaderText = "ID";
                colId.MinimumWidth = 60;
                dgvProductos.Columns.Add(colId);

                var colNombre = new DataGridViewTextBoxColumn();
                colNombre.DataPropertyName = "NombreProducto";
                colNombre.HeaderText = "Nombre";
                colNombre.MinimumWidth = 150;
                dgvProductos.Columns.Add(colNombre);

                var colCategoria = new DataGridViewTextBoxColumn();
                colCategoria.DataPropertyName = "Categoria";
                colCategoria.HeaderText = "Categoria";
                colCategoria.MinimumWidth = 100;
                dgvProductos.Columns.Add(colCategoria);

                var colPrecio = new DataGridViewTextBoxColumn();
                colPrecio.DataPropertyName = "PrecioVenta";
                colPrecio.HeaderText = "Precio Venta";
                colPrecio.MinimumWidth = 80;
                dgvProductos.Columns.Add(colPrecio);

                var colEstado = new DataGridViewTextBoxColumn();
                colEstado.HeaderText = "Estado";
                colEstado.MinimumWidth = 80;
                colEstado.ReadOnly = true;
                dgvProductos.Columns.Add(colEstado);
            }

            // Populate Estado column with textual values
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                var row = dgvProductos.Rows[i];
                var producto = row.DataBoundItem as CapaEntidad.Producto;
                if (producto != null)
                {
                    row.Cells[4].Value = producto.Activo ? "Activo" : "Inactivo";
                }
            }
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtCategoria.Clear();
            nudPrecioVenta.Value = nudPrecioVenta.Minimum;
            chkActivo.Checked = true;
            txtIdProducto.Enabled = true;
            txtIdProducto.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow fila = dgvProductos.Rows[e.RowIndex];

            if (fila.IsNewRow)
            {
                return;
            }
            // Usar helper compartido para obtener los valores de las celdas de forma segura por clave de columna
            var idVal = DataGridViewHelper.GetCellValue(dgvProductos, fila, "IdProducto");
            if (idVal == null)
            {
                return;
            }

            txtIdProducto.Text = idVal.ToString();
            txtNombreProducto.Text = DataGridViewHelper.GetCellValue(dgvProductos, fila, "NombreProducto")?.ToString() ?? string.Empty;
            txtCategoria.Text = DataGridViewHelper.GetCellValue(dgvProductos, fila, "Categoria")?.ToString() ?? string.Empty;

            var precioVal = DataGridViewHelper.GetCellValue(dgvProductos, fila, "PrecioVenta");
            if (precioVal != null && decimal.TryParse(precioVal.ToString(), out decimal precio))
            {
                nudPrecioVenta.Value = precio;
            }

            var activoVal = DataGridViewHelper.GetCellValue(dgvProductos, fila, "Activo");
            if (activoVal != null && bool.TryParse(activoVal.ToString(), out bool activo))
            {
                chkActivo.Checked = activo;
            }

            txtIdProducto.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Producto Producto = new(
                id,
                txtNombreProducto.Text,
                txtCategoria.Text,
                nudPrecioVenta.Value,
                chkActivo.Checked
            );

            string? error = _productoLN.Actualizar(Producto);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Producto actualizado correctamente.");

            CargarProductos();
            LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
        }

        private void nudPrecioVenta_Enter(object sender, EventArgs e)
        {
            nudPrecioVenta.Select(0, nudPrecioVenta.Text.Length);
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdProducto.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Producto? Producto = _productoLN.BuscarPorID(id);

            if (Producto == null)
            {
                MessageBox.Show("No se encontró un Producto con ese ID.");
                return;
            }

            txtNombreProducto.Text = Producto.NombreProducto;
            txtCategoria.Text = Producto.Categoria;
            nudPrecioVenta.Value = Producto.PrecioVenta;
            chkActivo.Checked = Producto.Activo;

            txtIdProducto.Enabled = false;
        }
    }
}
