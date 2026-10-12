namespace CapaPresentacion
{
    partial class FrmIngrediente
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
            lblIdIngrediente = new Label();
            lblNombreIngrediente = new Label();
            lblUnidadMedida = new Label();
            lblExistenciaActual = new Label();
            lblCostoUnitario = new Label();
            txtIdIngrediente = new TextBox();
            txtNombreIngrediente = new TextBox();
            txtUnidadMedida = new TextBox();
            btnRegistrar = new Button();
            nudExistenciaActual = new NumericUpDown();
            nudCostoUnitario = new NumericUpDown();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            dgvIngredientes = new DataGridView();
            btnBuscarPorID = new Button();
            ((System.ComponentModel.ISupportInitialize)nudExistenciaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCostoUnitario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).BeginInit();
            SuspendLayout();
            // 
            // lblIdIngrediente
            // 
            lblIdIngrediente.AutoSize = true;
            lblIdIngrediente.Location = new Point(47, 35);
            lblIdIngrediente.Name = "lblIdIngrediente";
            lblIdIngrediente.Size = new Size(81, 15);
            lblIdIngrediente.TabIndex = 0;
            lblIdIngrediente.Text = "ID Ingrediente";
            // 
            // lblNombreIngrediente
            // 
            lblNombreIngrediente.AutoSize = true;
            lblNombreIngrediente.Location = new Point(47, 72);
            lblNombreIngrediente.Name = "lblNombreIngrediente";
            lblNombreIngrediente.Size = new Size(51, 15);
            lblNombreIngrediente.TabIndex = 1;
            lblNombreIngrediente.Text = "Nombre";
            // 
            // lblUnidadMedida
            // 
            lblUnidadMedida.AutoSize = true;
            lblUnidadMedida.Location = new Point(47, 109);
            lblUnidadMedida.Name = "lblUnidadMedida";
            lblUnidadMedida.Size = new Size(104, 15);
            lblUnidadMedida.TabIndex = 2;
            lblUnidadMedida.Text = "Unidad de medida";
            // 
            // lblExistenciaActual
            // 
            lblExistenciaActual.AutoSize = true;
            lblExistenciaActual.Location = new Point(47, 146);
            lblExistenciaActual.Name = "lblExistenciaActual";
            lblExistenciaActual.Size = new Size(93, 15);
            lblExistenciaActual.TabIndex = 3;
            lblExistenciaActual.Text = "Existencia actual";
            // 
            // lblCostoUnitario
            // 
            lblCostoUnitario.AutoSize = true;
            lblCostoUnitario.Location = new Point(47, 183);
            lblCostoUnitario.Name = "lblCostoUnitario";
            lblCostoUnitario.Size = new Size(82, 15);
            lblCostoUnitario.TabIndex = 4;
            lblCostoUnitario.Text = "Costo unitario";
            // 
            // txtIdIngrediente
            // 
            txtIdIngrediente.Location = new Point(164, 35);
            txtIdIngrediente.Name = "txtIdIngrediente";
            txtIdIngrediente.Size = new Size(200, 23);
            txtIdIngrediente.TabIndex = 5;
            // 
            // txtNombreIngrediente
            // 
            txtNombreIngrediente.Location = new Point(164, 70);
            txtNombreIngrediente.Name = "txtNombreIngrediente";
            txtNombreIngrediente.Size = new Size(200, 23);
            txtNombreIngrediente.TabIndex = 6;
            // 
            // txtUnidadMedida
            // 
            txtUnidadMedida.Location = new Point(164, 105);
            txtUnidadMedida.Name = "txtUnidadMedida";
            txtUnidadMedida.Size = new Size(200, 23);
            txtUnidadMedida.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(470, 81);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 25);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // nudExistenciaActual
            // 
            nudExistenciaActual.Location = new Point(164, 140);
            nudExistenciaActual.Name = "nudExistenciaActual";
            nudExistenciaActual.Size = new Size(200, 23);
            nudExistenciaActual.TabIndex = 8;
            nudExistenciaActual.Enter += nudExistenciaActual_Enter;
            // 
            // nudCostoUnitario
            // 
            nudCostoUnitario.Location = new Point(164, 175);
            nudCostoUnitario.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCostoUnitario.Name = "nudCostoUnitario";
            nudCostoUnitario.Size = new Size(200, 23);
            nudCostoUnitario.TabIndex = 9;
            nudCostoUnitario.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(470, 127);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 25);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(470, 173);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 25);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvIngredientes
            // 
            dgvIngredientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvIngredientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIngredientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredientes.Location = new Point(47, 242);
            dgvIngredientes.MultiSelect = false;
            dgvIngredientes.Name = "dgvIngredientes";
            dgvIngredientes.ReadOnly = true;
            dgvIngredientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredientes.Size = new Size(700, 200);
            dgvIngredientes.TabIndex = 16;
            dgvIngredientes.CellClick += dgvIngredientes_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(470, 35);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(150, 25);
            btnBuscarPorID.TabIndex = 10;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // FrmIngrediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvIngredientes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(nudCostoUnitario);
            Controls.Add(nudExistenciaActual);
            Controls.Add(btnRegistrar);
            Controls.Add(txtUnidadMedida);
            Controls.Add(txtNombreIngrediente);
            Controls.Add(txtIdIngrediente);
            Controls.Add(lblCostoUnitario);
            Controls.Add(lblExistenciaActual);
            Controls.Add(lblUnidadMedida);
            Controls.Add(lblNombreIngrediente);
            Controls.Add(lblIdIngrediente);
            Name = "FrmIngrediente";
            Text = "FrmIngrediente";
            ((System.ComponentModel.ISupportInitialize)nudExistenciaActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCostoUnitario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvIngredientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdIngrediente;
        private Label lblNombreIngrediente;
        private Label lblUnidadMedida;
        private Label lblExistenciaActual;
        private Label lblCostoUnitario;
        private TextBox txtIdIngrediente;
        private TextBox txtNombreIngrediente;
        private TextBox txtUnidadMedida;
        private TextBox txtCostoUnitario;
        private Button btnRegistrar;
        private NumericUpDown nudExistenciaActual;
        private NumericUpDown nudCostoUnitario;
        private Button btnActualizar;
        private Button btnLimpiar;
        private TextBox txtExistenciaActual;
        private DataGridView dgvIngredientes;
        private Button btnBuscarPorID;
    }
}