namespace CapaPresentacion
{
    partial class FrmCajero
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
            lblIdCajero = new Label();
            lblIdentificacion = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblFechaNacimiento = new Label();
            lblFechaIngreso = new Label();
            txtIdCajero = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaIngreso = new DateTimePicker();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            dgvCajeros = new DataGridView();
            btnBuscarPorID = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCajeros).BeginInit();
            SuspendLayout();
            // 
            // lblIdCajero
            // 
            lblIdCajero.AutoSize = true;
            lblIdCajero.Location = new Point(42, 27);
            lblIdCajero.Name = "lblIdCajero";
            lblIdCajero.Size = new Size(55, 15);
            lblIdCajero.TabIndex = 0;
            lblIdCajero.Text = "ID Cajero";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(42, 64);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 1;
            lblIdentificacion.Text = "Identificación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(42, 138);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(42, 175);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(103, 15);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(42, 212);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(80, 15);
            lblFechaIngreso.TabIndex = 5;
            lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // txtIdCajero
            // 
            txtIdCajero.Location = new Point(185, 27);
            txtIdCajero.Name = "txtIdCajero";
            txtIdCajero.Size = new Size(200, 23);
            txtIdCajero.TabIndex = 6;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(185, 61);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(200, 23);
            txtIdentificacion.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(185, 135);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 9;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(185, 172);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(185, 209);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(200, 23);
            dtpFechaIngreso.TabIndex = 11;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(456, 84);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 25);
            btnRegistrar.TabIndex = 12;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(456, 131);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 25);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(456, 178);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 25);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvCajeros
            // 
            dgvCajeros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCajeros.Location = new Point(42, 263);
            dgvCajeros.MultiSelect = false;
            dgvCajeros.Name = "dgvCajeros";
            dgvCajeros.ReadOnly = true;
            dgvCajeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCajeros.Size = new Size(700, 200);
            dgvCajeros.TabIndex = 15;
            dgvCajeros.CellClick += dgvCajeros_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(456, 39);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(150, 25);
            btnBuscarPorID.TabIndex = 16;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // FrmCajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvCajeros);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtIdCajero);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblIdCajero);
            Name = "FrmCajero";
            Text = "Cajeros";
            ((System.ComponentModel.ISupportInitialize)dgvCajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCajero;
        private Label lblIdentificacion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblFechaIngreso;
        private TextBox txtIdCajero;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaIngreso;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private DataGridView dgvCajeros;
        private Button btnBuscarPorID;
    }
}
