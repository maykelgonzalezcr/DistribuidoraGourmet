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
    public partial class FrmCliente : Form
    {
        private ClienteLN _clienteLN;

        public FrmCliente(ClienteLN clienteLN)
        {
            InitializeComponent();

            _clienteLN = clienteLN;
            chkActivo.Checked = true;
            CargarClientes();
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cliente cliente = new(
                id,
                txtIdentificacion.Text,
                txtNombre.Text,
                txtApellido.Text,
                dtpFechaNacimiento.Value.Date,
                dtpFechaRegistro.Value.Date,
                chkActivo.Checked
            );

            string? error = _clienteLN.Registrar(cliente);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Cliente registrado correctamente.");
            CargarClientes();
            LimpiarCampos();

        }

        private void CargarClientes()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = _clienteLN.Listar();

            if (dgvClientes.Columns.Count == 0)
            {
                dgvClientes.Columns.Clear();

                var colId = new DataGridViewTextBoxColumn();
                colId.DataPropertyName = "IdCliente";
                colId.HeaderText = "ID";
                colId.MinimumWidth = 60;
                dgvClientes.Columns.Add(colId);

                var colIdent = new DataGridViewTextBoxColumn();
                colIdent.DataPropertyName = "Identificacion";
                colIdent.HeaderText = "Identificacion";
                colIdent.MinimumWidth = 120;
                dgvClientes.Columns.Add(colIdent);

                var colNombre = new DataGridViewTextBoxColumn();
                colNombre.DataPropertyName = "Nombre";
                colNombre.HeaderText = "Nombre";
                colNombre.MinimumWidth = 150;
                dgvClientes.Columns.Add(colNombre);

                var colApellido = new DataGridViewTextBoxColumn();
                colApellido.DataPropertyName = "Apellido";
                colApellido.HeaderText = "Apellido";
                colApellido.MinimumWidth = 150;
                dgvClientes.Columns.Add(colApellido);

                var colEstado = new DataGridViewTextBoxColumn();
                colEstado.HeaderText = "Estado";
                colEstado.MinimumWidth = 80;
                colEstado.ReadOnly = true;
                dgvClientes.Columns.Add(colEstado);
            }

            for (int i = 0; i < dgvClientes.Rows.Count; i++)
            {
                var row = dgvClientes.Rows[i];
                var cliente = row.DataBoundItem as CapaEntidad.Cliente;
                if (cliente != null)
                {
                    // Mostrar texto simple: "Activo" o "Inactivo"
                    row.Cells[4].Value = cliente.Activo ? "Activo" : "Inactivo";
                }
            }
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today.AddYears(-18);
            dtpFechaRegistro.Value = DateTime.Today;
            chkActivo.Checked = true;
            txtIdCliente.Enabled = true;
            txtIdCliente.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Intentionally do nothing on grid clicks per project-wide decision.
            return;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
            if (!int.TryParse(txtIdCliente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cliente cliente = new(
                id,
                txtIdentificacion.Text,
                txtNombre.Text,
                txtApellido.Text,
                dtpFechaNacimiento.Value.Date,
                dtpFechaRegistro.Value.Date,
                chkActivo.Checked
            );

            string? error = _clienteLN.Actualizar(cliente);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Cliente actualizado correctamente.");

            CargarClientes();
            LimpiarCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error inesperado: {ex.Message}");
            }
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Cliente? cliente = _clienteLN.BuscarPorID(id);

            if (cliente == null)
            {
                MessageBox.Show("No se encontró un cliente con ese ID.");
                return;
            }

            txtIdentificacion.Text = cliente.Identificacion;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            dtpFechaNacimiento.Value = cliente.FechaNacimiento.Date;
            dtpFechaRegistro.Value = cliente.FechaRegistro.Date;
            chkActivo.Checked = cliente.Activo;

            txtIdCliente.Enabled = false;
        }
    }
}
