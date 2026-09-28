namespace CapaPresentacion
{
    partial class FrmCliente
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
            lblIdCliente = new Label();
            lblIdentificacion = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblFechaNacimiento = new Label();
            lblFechaRegistro = new Label();
            lblActivo = new Label();
            txtIdCliente = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaRegistro = new DateTimePicker();
            chkActivo = new CheckBox();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            dgvClientes = new DataGridView();
            btnBuscarPorID = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(63, 74);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(61, 15);
            lblIdCliente.TabIndex = 0;
            lblIdCliente.Text = "ID Cliente";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(63, 111);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(80, 15);
            lblIdentificacion.TabIndex = 1;
            lblIdentificacion.Text = "Identificación";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(63, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(63, 185);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(63, 222);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 4;
            lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // lblFechaRegistro
            // 
            lblFechaRegistro.AutoSize = true;
            lblFechaRegistro.Location = new Point(63, 259);
            lblFechaRegistro.Name = "lblFechaRegistro";
            lblFechaRegistro.Size = new Size(95, 15);
            lblFechaRegistro.TabIndex = 5;
            lblFechaRegistro.Text = "Fecha Registro";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(63, 296);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 6;
            lblActivo.Text = "Activo";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(206, 74);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(125, 23);
            txtIdCliente.TabIndex = 7;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(206, 108);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(125, 23);
            txtIdentificacion.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(206, 145);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(206, 182);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 23);
            txtApellido.TabIndex = 10;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(206, 219);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(206, 256);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(200, 23);
            dtpFechaRegistro.TabIndex = 12;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(206, 296);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 13;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(470, 111);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 25);
            btnRegistrar.TabIndex = 14;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(470, 158);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(154, 25);
            btnActualizar.TabIndex = 15;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(470, 205);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 25);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(48, 340);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(715, 103);
            dgvClientes.TabIndex = 17;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(470, 66);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(154, 25);
            btnBuscarPorID.TabIndex = 18;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 475);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvClientes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrar);
            Controls.Add(chkActivo);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtIdCliente);
            Controls.Add(lblActivo);
            Controls.Add(lblFechaRegistro);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblIdCliente);
            Name = "FrmCliente";
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdCliente;
        private Label lblIdentificacion;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblFechaNacimiento;
        private Label lblFechaRegistro;
        private Label lblActivo;
        private TextBox txtIdCliente;
        private TextBox txtIdentificacion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaRegistro;
        private CheckBox chkActivo;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnLimpiar;
        private DataGridView dgvClientes;
        private Button btnBuscarPorID;
    }
}
