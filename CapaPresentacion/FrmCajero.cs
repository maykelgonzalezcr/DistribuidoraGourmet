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
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
        }

        private void CargarCajeros()
        {
            dgvCajeros.AutoGenerateColumns = false;
            dgvCajeros.DataSource = _cajeroLN.Listar();

            if (dgvCajeros.Columns.Count == 0)
            {
                dgvCajeros.Columns.Clear();

                var colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdCajero";
                colId.HeaderText = "ID";
                colId.MinimumWidth = 60;
                dgvCajeros.Columns.Add(colId);

                var colIdent = new DataGridViewTextBoxColumn();
                colIdent.DataPropertyName = "Identificacion";
                colIdent.HeaderText = "Identificacion";
                colIdent.MinimumWidth = 120;
                dgvCajeros.Columns.Add(colIdent);

                var colNombre = new DataGridViewTextBoxColumn();
                colNombre.DataPropertyName = "Nombre";
                colNombre.HeaderText = "Nombre";
                colNombre.MinimumWidth = 150;
                dgvCajeros.Columns.Add(colNombre);

                var colApellido = new DataGridViewTextBoxColumn();
                colApellido.DataPropertyName = "Apellido";
                colApellido.HeaderText = "Apellido";
                colApellido.MinimumWidth = 150;
                dgvCajeros.Columns.Add(colApellido);

                var colIngreso = new DataGridViewTextBoxColumn();
                colIngreso.DataPropertyName = "FechaIngreso";
                colIngreso.HeaderText = "Fecha Ingreso";
                colIngreso.MinimumWidth = 100;
                dgvCajeros.Columns.Add(colIngreso);
            }

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
            // Intentionally do nothing on grid clicks per project-wide decision.
            return;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
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
