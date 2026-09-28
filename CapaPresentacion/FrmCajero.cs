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
    public partial class FrmCajero : Form
    {
        private CajeroLN _cajeroLN;

        public FrmCajero(CajeroLN cajeroLN)
        {
            InitializeComponent();

            _cajeroLN = cajeroLN;
            CargarCajeros();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCajero.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cajero cajero = new(
                id,
                txtIdentificacion.Text,
                txtNombre.Text,
                txtApellido.Text,
                dtpFechaNacimiento.Value.Date,
                dtpFechaIngreso.Value.Date
            );

            string? error = _cajeroLN.Registrar(cajero);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Cajero registrado correctamente.");
            CargarCajeros();
            LimpiarCampos();
        }

        private void CargarCajeros()
        {
            dgvCajeros.DataSource = _cajeroLN.Listar();
        }

        private void LimpiarCampos()
        {
            txtIdCajero.Clear();
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-18);
            dtpFechaIngreso.Value = DateTime.Today;
            txtIdCajero.Enabled = true;
            txtIdCajero.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvCajeros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvCajeros.Rows[e.RowIndex];

            txtIdCajero.Text = fila.Cells["IdCajero"].Value.ToString();
            txtIdentificacion.Text = fila.Cells["Identificacion"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value).Date;
            dtpFechaIngreso.Value = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value).Date;

            txtIdCajero.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCajero.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cajero cajero = new(
                id,
                txtIdentificacion.Text,
                txtNombre.Text,
                txtApellido.Text,
                dtpFechaNacimiento.Value.Date,
                dtpFechaIngreso.Value.Date
            );

            string? error = _cajeroLN.Actualizar(cajero);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Cajero actualizado correctamente.");
            CargarCajeros();
            LimpiarCampos();
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCajero.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cajero? cajero = _cajeroLN.BuscarPorID(id);

            if (cajero == null)
            {
                MessageBox.Show("No se encontró un cajero con ese ID.");
                return;
            }

            txtIdentificacion.Text = cajero.Identificacion;
            txtNombre.Text = cajero.Nombre;
            txtApellido.Text = cajero.Apellido;
            dtpFechaNacimiento.Value = cajero.FechaNacimiento.Date;
            dtpFechaIngreso.Value = cajero.FechaIngreso.Date;

            txtIdCajero.Enabled = false;
        }
    }
}
