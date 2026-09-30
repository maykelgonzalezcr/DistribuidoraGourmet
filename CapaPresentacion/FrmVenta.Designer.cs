namespace CapaPresentacion
{
    partial class FrmVenta
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
            lblIdVenta = new Label();
            lblCliente = new Label();
            lblCajero = new Label();
            lblProduccion = new Label();
            lblCantidad = new Label();
            lblFechaVenta = new Label();
            lblSubTotal = new Label();
            lblImpuesto = new Label();
            lblTotalVenta = new Label();
            lblTipoVenta = new Label();
            txtIdVenta = new TextBox();
            cmbCliente = new ComboBox();
            cmbCajero = new ComboBox();
            cmbProduccion = new ComboBox();
            nudCantidad = new NumericUpDown();
            dtpFechaVenta = new DateTimePicker();
            txtSubTotal = new TextBox();
            txtImpuesto = new TextBox();
            txtTotalVenta = new TextBox();
            txtTipoVenta = new TextBox();
            btnRegistrar = new Button();
            btnBuscarPorID = new Button();
            btnLimpiar = new Button();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.Location = new Point(70, 17);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Size = new Size(50, 15);
            lblIdVenta.TabIndex = 0;
            lblIdVenta.Text = "ID Venta";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(70, 50);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblCajero
            // 
            lblCajero.AutoSize = true;
            lblCajero.Location = new Point(70, 83);
            lblCajero.Name = "lblCajero";
            lblCajero.Size = new Size(41, 15);
            lblCajero.TabIndex = 2;
            lblCajero.Text = "Cajero";
            // 
            // lblProduccion
            // 
            lblProduccion.AutoSize = true;
            lblProduccion.Location = new Point(70, 116);
            lblProduccion.Name = "lblProduccion";
            lblProduccion.Size = new Size(68, 15);
            lblProduccion.TabIndex = 3;
            lblProduccion.Text = "Producción";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(70, 149);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "Cantidad";
            // 
            // lblFechaVenta
            // 
            lblFechaVenta.AutoSize = true;
            lblFechaVenta.Location = new Point(430, 86);
            lblFechaVenta.Name = "lblFechaVenta";
            lblFechaVenta.Size = new Size(70, 15);
            lblFechaVenta.TabIndex = 5;
            lblFechaVenta.Text = "Fecha Venta";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(70, 182);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(53, 15);
            lblSubTotal.TabIndex = 6;
            lblSubTotal.Text = "SubTotal";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(70, 215);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(57, 15);
            lblImpuesto.TabIndex = 7;
            lblImpuesto.Text = "Impuesto";
            // 
            // lblTotalVenta
            // 
            lblTotalVenta.AutoSize = true;
            lblTotalVenta.Location = new Point(430, 20);
            lblTotalVenta.Name = "lblTotalVenta";
            lblTotalVenta.Size = new Size(65, 15);
            lblTotalVenta.TabIndex = 8;
            lblTotalVenta.Text = "Total Venta";
            // 
            // lblTipoVenta
            // 
            lblTipoVenta.AutoSize = true;
            lblTipoVenta.Location = new Point(430, 53);
            lblTipoVenta.Name = "lblTipoVenta";
            lblTipoVenta.Size = new Size(63, 15);
            lblTipoVenta.TabIndex = 9;
            lblTipoVenta.Text = "Tipo Venta";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Location = new Point(167, 17);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(200, 23);
            txtIdVenta.TabIndex = 10;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(167, 49);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(200, 23);
            cmbCliente.TabIndex = 11;
            cmbCliente.Format += cmbCliente_Format;
            // 
            // cmbCajero
            // 
            cmbCajero.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCajero.FormattingEnabled = true;
            cmbCajero.Location = new Point(167, 81);
            cmbCajero.Name = "cmbCajero";
            cmbCajero.Size = new Size(200, 23);
            cmbCajero.TabIndex = 12;
            cmbCajero.Format += cmbCajero_Format;
            // 
            // cmbProduccion
            // 
            cmbProduccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduccion.FormattingEnabled = true;
            cmbProduccion.Location = new Point(167, 113);
            cmbProduccion.Name = "cmbProduccion";
            cmbProduccion.Size = new Size(200, 23);
            cmbProduccion.TabIndex = 13;
            cmbProduccion.Format += cmbProduccion_Format;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(167, 145);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(200, 23);
            nudCantidad.TabIndex = 14;
            // 
            // dtpFechaVenta
            // 
            dtpFechaVenta.Location = new Point(524, 77);
            dtpFechaVenta.Name = "dtpFechaVenta";
            dtpFechaVenta.Size = new Size(200, 23);
            dtpFechaVenta.TabIndex = 15;
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = SystemColors.Window;
            txtSubTotal.Location = new Point(167, 177);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(200, 23);
            txtSubTotal.TabIndex = 16;
            // 
            // txtImpuesto
            // 
            txtImpuesto.BackColor = SystemColors.Window;
            txtImpuesto.Location = new Point(167, 209);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.Size = new Size(200, 23);
            txtImpuesto.TabIndex = 17;
            // 
            // txtTotalVenta
            // 
            txtTotalVenta.BackColor = SystemColors.Window;
            txtTotalVenta.Location = new Point(524, 13);
            txtTotalVenta.Name = "txtTotalVenta";
            txtTotalVenta.ReadOnly = true;
            txtTotalVenta.Size = new Size(200, 23);
            txtTotalVenta.TabIndex = 18;
            // 
            // txtTipoVenta
            // 
            txtTipoVenta.BackColor = SystemColors.Window;
            txtTipoVenta.Location = new Point(524, 45);
            txtTipoVenta.Name = "txtTipoVenta";
            txtTipoVenta.ReadOnly = true;
            txtTipoVenta.Size = new Size(200, 23);
            txtTipoVenta.TabIndex = 19;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(509, 170);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 25);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(509, 139);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(150, 25);
            btnBuscarPorID.TabIndex = 21;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(509, 201);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 25);
            btnLimpiar.TabIndex = 22;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(40, 255);
            dgvVentas.MultiSelect = false;
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(700, 200);
            dgvVentas.TabIndex = 23;
            dgvVentas.CellClick += dgvVentas_CellClick;
            // 
            // FrmVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(dgvVentas);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscarPorID);
            Controls.Add(btnRegistrar);
            Controls.Add(txtTipoVenta);
            Controls.Add(txtTotalVenta);
            Controls.Add(txtImpuesto);
            Controls.Add(txtSubTotal);
            Controls.Add(dtpFechaVenta);
            Controls.Add(nudCantidad);
            Controls.Add(cmbProduccion);
            Controls.Add(cmbCajero);
            Controls.Add(cmbCliente);
            Controls.Add(txtIdVenta);
            Controls.Add(lblTipoVenta);
            Controls.Add(lblTotalVenta);
            Controls.Add(lblImpuesto);
            Controls.Add(lblSubTotal);
            Controls.Add(lblFechaVenta);
            Controls.Add(lblCantidad);
            Controls.Add(lblProduccion);
            Controls.Add(lblCajero);
            Controls.Add(lblCliente);
            Controls.Add(lblIdVenta);
            Name = "FrmVenta";
            Text = "Ventas";
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdVenta;
        private Label lblCliente;
        private Label lblCajero;
        private Label lblProduccion;
        private Label lblCantidad;
        private Label lblFechaVenta;
        private Label lblSubTotal;
        private Label lblImpuesto;
        private Label lblTotalVenta;
        private Label lblTipoVenta;
        private TextBox txtIdVenta;
        private ComboBox cmbCliente;
        private ComboBox cmbCajero;
        private ComboBox cmbProduccion;
        private NumericUpDown nudCantidad;
        private DateTimePicker dtpFechaVenta;
        private TextBox txtSubTotal;
        private TextBox txtImpuesto;
        private TextBox txtTotalVenta;
        private TextBox txtTipoVenta;
        private Button btnRegistrar;
        private Button btnBuscarPorID;
        private Button btnLimpiar;
        private DataGridView dgvVentas;
    }
}
