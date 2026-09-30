namespace CapaPresentacion
{
    partial class FrmProduccion
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
            lblIdProduccion = new Label();
            lblProducto = new Label();
            lblCantidadProducida = new Label();
            lblFechaProduccion = new Label();
            txtIdProduccion = new TextBox();
            cmbProducto = new ComboBox();
            nudCantidadProducida = new NumericUpDown();
            dtpFechaProduccion = new DateTimePicker();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            dgvProducciones = new DataGridView();
            btnBuscarPorID = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidadProducida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducciones).BeginInit();
            SuspendLayout();
            // 
            // lblIdProduccion
            // 
            lblIdProduccion.AutoSize = true;
            lblIdProduccion.Location = new Point(57, 38);
            lblIdProduccion.Name = "lblIdProduccion";
            lblIdProduccion.Size = new Size(82, 15);
            lblIdProduccion.TabIndex = 0;
            lblIdProduccion.Text = "ID Producción";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(57, 75);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 1;
            lblProducto.Text = "Producto";
            // 
            // lblCantidadProducida
            // 
            lblCantidadProducida.AutoSize = true;
            lblCantidadProducida.Location = new Point(57, 112);
            lblCantidadProducida.Name = "lblCantidadProducida";
            lblCantidadProducida.Size = new Size(112, 15);
            lblCantidadProducida.TabIndex = 2;
            lblCantidadProducida.Text = "Cantidad Producida";
            // 
            // lblFechaProduccion
            // 
            lblFechaProduccion.AutoSize = true;
            lblFechaProduccion.Location = new Point(57, 149);
            lblFechaProduccion.Name = "lblFechaProduccion";
            lblFechaProduccion.Size = new Size(102, 15);
            lblFechaProduccion.TabIndex = 3;
            lblFechaProduccion.Text = "Fecha Producción";
            // 
            // txtIdProduccion
            // 
            txtIdProduccion.Location = new Point(200, 38);
            txtIdProduccion.Name = "txtIdProduccion";
            txtIdProduccion.Size = new Size(200, 23);
            txtIdProduccion.TabIndex = 4;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(200, 72);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(200, 23);
            cmbProducto.TabIndex = 5;
            // 
            // nudCantidadProducida
            // 
            nudCantidadProducida.Location = new Point(200, 109);
            nudCantidadProducida.Name = "nudCantidadProducida";
            nudCantidadProducida.Size = new Size(200, 23);
            nudCantidadProducida.TabIndex = 6;
            // 
            // dtpFechaProduccion
            // 
            dtpFechaProduccion.Location = new Point(200, 146);
            dtpFechaProduccion.Name = "dtpFechaProduccion";
            dtpFechaProduccion.Size = new Size(200, 23);
            dtpFechaProduccion.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(494, 83);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 25);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(494, 130);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 25);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvProducciones
            // 
            dgvProducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducciones.Location = new Point(40, 227);
            dgvProducciones.MultiSelect = false;
            dgvProducciones.Name = "dgvProducciones";
            dgvProducciones.ReadOnly = true;
            dgvProducciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducciones.Size = new Size(700, 200);
            dgvProducciones.TabIndex = 10;
            dgvProducciones.CellClick += dgvProducciones_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(494, 38);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(154, 25);
            btnBuscarPorID.TabIndex = 11;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // FrmProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvProducciones);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaProduccion);
            Controls.Add(nudCantidadProducida);
            Controls.Add(cmbProducto);
            Controls.Add(txtIdProduccion);
            Controls.Add(lblFechaProduccion);
            Controls.Add(lblCantidadProducida);
            Controls.Add(lblProducto);
            Controls.Add(lblIdProduccion);
            Name = "FrmProduccion";
            Text = "Producción";
            ((System.ComponentModel.ISupportInitialize)nudCantidadProducida).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdProduccion;
        private Label lblProducto;
        private Label lblCantidadProducida;
        private Label lblFechaProduccion;
        private TextBox txtIdProduccion;
        private ComboBox cmbProducto;
        private NumericUpDown nudCantidadProducida;
        private DateTimePicker dtpFechaProduccion;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private DataGridView dgvProducciones;
        private Button btnBuscarPorID;
    }
}
