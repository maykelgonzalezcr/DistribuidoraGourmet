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

            this._productoLN = productoLN;
            chkActivo.Checked = true;
            CargarProductos();
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
            dgvProductos.DataSource = _productoLN.Listar();
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

            txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
            txtNombreProducto.Text = fila.Cells["NombreProducto"].Value.ToString();
            txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
            nudPrecioVenta.Value = Convert.ToDecimal(fila.Cells["PrecioVenta"].Value);
            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);

            txtIdProducto.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
