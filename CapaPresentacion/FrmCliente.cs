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
            dgvClientes.DataSource = _clienteLN.Listar();
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
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

            txtIdCliente.Text = fila.Cells["IdCliente"].Value.ToString();
            txtIdentificacion.Text = fila.Cells["Identificacion"].Value.ToString();
            txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
            dtpFechaNacimiento.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value).Date;
            dtpFechaRegistro.Value = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value).Date;
            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);

            txtIdCliente.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
