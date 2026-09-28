namespace CapaPresentacion
{
    partial class FrmRecetaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIdRecetaProducto = new Label();
            lblProducto = new Label();
            lblIngrediente = new Label();
            lblCantidadRequerida = new Label();
            txtIdRecetaProducto = new TextBox();
            cmbProducto = new ComboBox();
            cmbIngrediente = new ComboBox();
            nudCantidadRequerida = new NumericUpDown();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dgvRecetas = new DataGridView();
            btnBuscarPorID = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidadRequerida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).BeginInit();
            SuspendLayout();
            // 
            // lblIdRecetaProducto
            // 
            lblIdRecetaProducto.AutoSize = true;
            lblIdRecetaProducto.Location = new Point(63, 74);
            lblIdRecetaProducto.Name = "lblIdRecetaProducto";
            lblIdRecetaProducto.Size = new Size(99, 15);
            lblIdRecetaProducto.TabIndex = 0;
            lblIdRecetaProducto.Text = "ID Receta Producto";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(63, 111);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(54, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblIngrediente
            // 
            lblIngrediente.AutoSize = true;
            lblIngrediente.Location = new Point(63, 148);
            lblIngrediente.Name = "lblIngrediente";
            lblIngrediente.Size = new Size(69, 15);
            lblIngrediente.TabIndex = 2;
            lblIngrediente.Text = "Ingrediente";
            // 
            // lblCantidadRequerida
            // 
            lblCantidadRequerida.AutoSize = true;
            lblCantidadRequerida.Location = new Point(63, 185);
            lblCantidadRequerida.Name = "lblCantidadRequerida";
            lblCantidadRequerida.Size = new Size(115, 15);
            lblCantidadRequerida.TabIndex = 3;
            lblCantidadRequerida.Text = "Cantidad Requerida";
            // 
            // txtIdRecetaProducto
            // 
            txtIdRecetaProducto.Location = new Point(206, 74);
            txtIdRecetaProducto.Name = "txtIdRecetaProducto";
            txtIdRecetaProducto.Size = new Size(125, 23);
            txtIdRecetaProducto.TabIndex = 4;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(206, 108);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(200, 23);
            cmbProducto.TabIndex = 5;
            // 
            // cmbIngrediente
            // 
            cmbIngrediente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngrediente.FormattingEnabled = true;
            cmbIngrediente.Location = new Point(206, 145);
            cmbIngrediente.Name = "cmbIngrediente";
            cmbIngrediente.Size = new Size(200, 23);
            cmbIngrediente.TabIndex = 6;
            // 
            // nudCantidadRequerida
            // 
            nudCantidadRequerida.Location = new Point(206, 182);
            nudCantidadRequerida.Name = "nudCantidadRequerida";
            nudCantidadRequerida.Size = new Size(125, 23);
            nudCantidadRequerida.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(470, 111);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 25);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(470, 158);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 25);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvRecetas
            // 
            dgvRecetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecetas.Location = new Point(48, 321);
            dgvRecetas.MultiSelect = false;
            dgvRecetas.Name = "dgvRecetas";
            dgvRecetas.ReadOnly = true;
            dgvRecetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecetas.Size = new Size(715, 103);
            dgvRecetas.TabIndex = 10;
            dgvRecetas.CellClick += dgvRecetas_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(470, 66);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(154, 25);
            btnBuscarPorID.TabIndex = 11;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // FrmRecetaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 475);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvRecetas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(nudCantidadRequerida);
            Controls.Add(cmbIngrediente);
            Controls.Add(cmbProducto);
            Controls.Add(txtIdRecetaProducto);
            Controls.Add(lblCantidadRequerida);
            Controls.Add(lblIngrediente);
            Controls.Add(lblProducto);
            Controls.Add(lblIdRecetaProducto);
            Name = "FrmRecetaProducto";
            Text = "Recetas";
            ((System.ComponentModel.ISupportInitialize)nudCantidadRequerida).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecetas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdRecetaProducto;
        private Label lblProducto;
        private Label lblIngrediente;
        private Label lblCantidadRequerida;
        private TextBox txtIdRecetaProducto;
        private ComboBox cmbProducto;
        private ComboBox cmbIngrediente;
        private NumericUpDown nudCantidadRequerida;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridView dgvRecetas;
        private Button btnBuscarPorID;
    }
}
