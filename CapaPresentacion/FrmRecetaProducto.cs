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

            // Establecer máximo para cantidad requerida según decimal
            nudCantidadRequerida.Maximum = decimal.MaxValue;

            _recetaProductoLN = recetaProductoLN;

            CargarProductos();
            CargarIngredientes();
            CargarRecetas();
            // Suscribir evento para garantizar que las celdas unbound se llenen después del binding
            dgvRecetas.DataBindingComplete -= DgvRecetas_DataBindingComplete;
            dgvRecetas.DataBindingComplete += DgvRecetas_DataBindingComplete;
            this.MinimumSize = new System.Drawing.Size(800, 600);
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

        private void DgvRecetas_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Rellenar manualmente Producto e Ingrediente después de que el DataGridView termine el binding
            var lista = _recetaProductoLN.Listar();
            if (lista == null) return;

            for (int i = 0; i < dgvRecetas.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvRecetas.Rows[i];
                if (fila.IsNewRow) continue;
                if (fila.DataBoundItem is RecetaProducto rp)
                {
                    // Expected columns:
                    // 0=IdRecetaProducto
                    // 1=Producto.IdProducto
                    // 2=Producto.NombreProducto
                    // 3=Producto.Categoria
                    // 4=Ingrediente.IdIngrediente
                    // 5=Ingrediente.NombreIngrediente
                    // 6=Ingrediente.UnidadMedida
                    // 7=CantidadRequerida
                    if (dgvRecetas.Columns.Count > 1)
                    {
                        fila.Cells[1].Value = rp.Producto != null ? rp.Producto.IdProducto : (object)string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 2)
                    {
                        fila.Cells[2].Value = rp.Producto != null ? rp.Producto.NombreProducto : string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 3)
                    {
                        fila.Cells[3].Value = rp.Producto != null ? rp.Producto.Categoria : string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 4)
                    {
                        fila.Cells[4].Value = rp.Ingrediente != null ? rp.Ingrediente.IdIngrediente : (object)string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 5)
                    {
                        fila.Cells[5].Value = rp.Ingrediente != null ? rp.Ingrediente.NombreIngrediente : string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 6)
                    {
                        fila.Cells[6].Value = rp.Ingrediente != null ? rp.Ingrediente.UnidadMedida : string.Empty;
                    }
                    if (dgvRecetas.Columns.Count > 7)
                    {
                        fila.Cells[7].Value = rp.CantidadRequerida;
                    }
                }
            }

            dgvRecetas.Refresh();
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

            if (dgvRecetas.Columns.Count == 0)
            {
                // Build columns matching requested layout: product id, name, category; ingredient id, name, unit; cantidad requerida
                void AddTextCol(string name, string header, string dataProp = "", int width = 100, DataGridViewContentAlignment align = DataGridViewContentAlignment.MiddleLeft)
                {
                    var c = new DataGridViewTextBoxColumn();
                    c.DataPropertyName = dataProp; // empty for manual fill
                    c.Name = name;
                    c.HeaderText = header;
                    c.Width = width;
                    c.DefaultCellStyle.Alignment = align;
                    dgvRecetas.Columns.Add(c);
                }

                AddTextCol("IdRecetaProducto", "ID", "IdRecetaProducto", 60, DataGridViewContentAlignment.MiddleCenter);
                AddTextCol("ProductoId", "Producto (IdProducto)", "", 100, DataGridViewContentAlignment.MiddleCenter);
                AddTextCol("ProductoNombre", "Producto (Nombre)", "", 140, DataGridViewContentAlignment.MiddleLeft);
                AddTextCol("ProductoCategoria", "Producto (Categoria)", "", 130, DataGridViewContentAlignment.MiddleLeft);
                AddTextCol("IngredienteId", "Ingrediente (IdIngrediente)", "", 110, DataGridViewContentAlignment.MiddleCenter);
                AddTextCol("IngredienteNombre", "Ingrediente (Nombre)", "", 140, DataGridViewContentAlignment.MiddleLeft);
                AddTextCol("IngredienteUnidad", "Ingrediente (UnidadMedida)", "", 120, DataGridViewContentAlignment.MiddleLeft);
                AddTextCol("CantidadRequerida", "Cantidad Requerida", "CantidadRequerida", 120, DataGridViewContentAlignment.MiddleRight);
            }

            var lista = _recetaProductoLN.Listar();

            dgvRecetas.DataSource = lista;

            // Rellenar manualmente las columnas que usan propiedades anidadas, porque el binding directo
            // a rutas como "Producto.NombreProducto" puede no mostrarlas correctamente en algunos casos.
            if (lista != null)
            {
                for (int i = 0; i < dgvRecetas.Rows.Count; i++)
                {
                    DataGridViewRow fila = dgvRecetas.Rows[i];
                    if (fila.IsNewRow) continue;
                    if (fila.DataBoundItem is RecetaProducto rp)
                    {
                        // populate new column layout
                        if (dgvRecetas.Columns.Count > 1)
                        {
                            fila.Cells[1].Value = rp.Producto != null ? rp.Producto.IdProducto : (object)string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 2)
                        {
                            fila.Cells[2].Value = rp.Producto != null ? rp.Producto.NombreProducto : string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 3)
                        {
                            fila.Cells[3].Value = rp.Producto != null ? rp.Producto.Categoria : string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 4)
                        {
                            fila.Cells[4].Value = rp.Ingrediente != null ? rp.Ingrediente.IdIngrediente : (object)string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 5)
                        {
                            fila.Cells[5].Value = rp.Ingrediente != null ? rp.Ingrediente.NombreIngrediente : string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 6)
                        {
                            fila.Cells[6].Value = rp.Ingrediente != null ? rp.Ingrediente.UnidadMedida : string.Empty;
                        }
                        if (dgvRecetas.Columns.Count > 7)
                        {
                            fila.Cells[7].Value = rp.CantidadRequerida;
                        }
                    }
                }
            }

            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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

            if (fila.IsNewRow)
            {
                return;
            }

            var idCell = fila.Cells[0]?.Value;
            if (idCell == null || !int.TryParse(idCell.ToString(), out int id))
            {
                return;
            }

            txtIdRecetaProducto.Text = id.ToString();

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
