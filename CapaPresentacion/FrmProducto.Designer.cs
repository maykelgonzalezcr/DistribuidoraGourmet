namespace CapaPresentacion
{
    partial class FrmProducto
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
            lblIdProducto = new Label();
            lblNombreProducto = new Label();
            lblCategoria = new Label();
            lblPrecioVenta = new Label();
            lblActivo = new Label();
            txtIdProducto = new TextBox();
            txtNombreProducto = new TextBox();
            txtCategoria = new TextBox();
            btnRegistrar = new Button();
            nudPrecioVenta = new NumericUpDown();
            btnActualizar = new Button();
            btnLimpiar = new Button();
            dgvProductos = new DataGridView();
            btnBuscarPorID = new Button();
            chkActivo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)nudPrecioVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(60, 31);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(70, 15);
            lblIdProducto.TabIndex = 0;
            lblIdProducto.Text = "ID Producto";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(60, 68);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(51, 15);
            lblNombreProducto.TabIndex = 1;
            lblNombreProducto.Text = "Nombre";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(60, 105);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(60, 142);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(72, 15);
            lblPrecioVenta.TabIndex = 3;
            lblPrecioVenta.Text = "Precio Venta";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(60, 179);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(41, 15);
            lblActivo.TabIndex = 4;
            lblActivo.Text = "Activo";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(169, 31);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 23);
            txtIdProducto.TabIndex = 5;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(169, 68);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(125, 23);
            txtNombreProducto.TabIndex = 6;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(169, 105);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(125, 23);
            txtCategoria.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(445, 76);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(154, 25);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // nudPrecioVenta
            // 
            nudPrecioVenta.Location = new Point(169, 142);
            nudPrecioVenta.Name = "nudPrecioVenta";
            nudPrecioVenta.Size = new Size(125, 23);
            nudPrecioVenta.TabIndex = 8;
            nudPrecioVenta.Enter += nudPrecioVenta_Enter;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(445, 121);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(154, 25);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(445, 166);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 25);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(39, 245);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(700, 200);
            dgvProductos.TabIndex = 16;
            dgvProductos.CellClick += dgvProductos_CellClick;
            // 
            // btnBuscarPorID
            // 
            btnBuscarPorID.Location = new Point(445, 31);
            btnBuscarPorID.Name = "btnBuscarPorID";
            btnBuscarPorID.Size = new Size(154, 25);
            btnBuscarPorID.TabIndex = 10;
            btnBuscarPorID.Text = "Buscar por ID";
            btnBuscarPorID.UseVisualStyleBackColor = true;
            btnBuscarPorID.Click += btnBuscarPorID_Click;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(169, 179);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(15, 14);
            chkActivo.TabIndex = 17;
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 486);
            Controls.Add(chkActivo);
            Controls.Add(btnBuscarPorID);
            Controls.Add(dgvProductos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Controls.Add(nudPrecioVenta);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtIdProducto);
            Controls.Add(lblActivo);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(lblIdProducto);
            Name = "FrmProducto";
            Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)nudPrecioVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdProducto;
        private Label lblNombreProducto;
        private Label lblCategoria;
        private Label lblPrecioVenta;
        private Label lblActivo;
        private TextBox txtIdProducto;
        private TextBox txtNombreProducto;
        private TextBox txtCategoria;
        private Button btnRegistrar;
        private NumericUpDown nudPrecioVenta;
        private Button btnActualizar;
        private Button btnLimpiar;
        private DataGridView dgvProductos;
        private Button btnBuscarPorID;
        private CheckBox chkActivo;
    }
}