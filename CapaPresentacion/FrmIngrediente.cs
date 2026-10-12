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
    public partial class FrmIngrediente : Form
    {
        private IngredienteLN _ingredienteLN;
        public FrmIngrediente(IngredienteLN ingredienteLN)
        {
            InitializeComponent();
            // Establecer máximos adecuados según el tipo de dato de la entidad
            nudExistenciaActual.Maximum = decimal.MaxValue;
            nudCostoUnitario.Maximum = decimal.MaxValue;

            this._ingredienteLN = ingredienteLN;
            CargarIngredientes();
            this.MinimumSize = new System.Drawing.Size(800, 600);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdIngrediente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Ingrediente ingrediente = new(
                id,
                txtNombreIngrediente.Text,
                txtUnidadMedida.Text,
                nudExistenciaActual.Value,
                nudCostoUnitario.Value
                );

            string? error = _ingredienteLN.Registrar(ingrediente);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Ingrediente registrado correctamente.");
            CargarIngredientes();
            LimpiarCampos();

        }

        private void CargarIngredientes()
        {
            dgvIngredientes.DataSource = _ingredienteLN.Listar();
        }

        private void LimpiarCampos()
        {
            txtIdIngrediente.Clear();
            txtNombreIngrediente.Clear();
            txtUnidadMedida.Clear();
            nudExistenciaActual.Value = nudExistenciaActual.Minimum;
            nudCostoUnitario.Value = nudCostoUnitario.Minimum;
            txtIdIngrediente.Enabled = true;
            txtIdIngrediente.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvIngredientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Intentionally do nothing on grid clicks per project-wide decision.
            return;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdIngrediente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Ingrediente ingrediente = new(
                id,
                txtNombreIngrediente.Text,
                txtUnidadMedida.Text,
                nudExistenciaActual.Value,
                nudCostoUnitario.Value
            );

            string? error = _ingredienteLN.Actualizar(ingrediente);

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Ingrediente actualizado correctamente.");

            CargarIngredientes();
            LimpiarCampos();
        }

        private void nudExistenciaActual_Enter(object sender, EventArgs e)
        {
            nudExistenciaActual.Select(0, nudExistenciaActual.Text.Length);
        }

        private void nudCostoUnitario_Enter(object sender, EventArgs e)
        {
            nudCostoUnitario.Select(0, nudCostoUnitario.Text.Length);
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdIngrediente.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número entero.");
                return;
            }

            Ingrediente? ingrediente = _ingredienteLN.BuscarPorID(id);

            if (ingrediente == null)
            {
                MessageBox.Show("No se encontró un ingrediente con ese ID.");
                return;
            }

            txtNombreIngrediente.Text = ingrediente.NombreIngrediente;
            txtUnidadMedida.Text = ingrediente.UnidadMedida;
            nudExistenciaActual.Value = ingrediente.ExistenciaActual;
            nudCostoUnitario.Value = ingrediente.CostoUnitario;

            txtIdIngrediente.Enabled = false;
        }
    }
}
