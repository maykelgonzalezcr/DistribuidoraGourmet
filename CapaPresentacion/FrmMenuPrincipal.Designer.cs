namespace CapaPresentacion
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIngredientes = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // btnIngredientes
            // 
            btnIngredientes.Location = new Point(98, 37);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(144, 31);
            btnIngredientes.TabIndex = 0;
            btnIngredientes.Text = "Ingredientes";
            btnIngredientes.UseVisualStyleBackColor = true;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(98, 84);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(144, 31);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes = new Button();
            btnClientes.Location = new Point(98, 131);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(144, 31);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCajeros
            // 
            btnCajeros = new Button();
            btnCajeros.Location = new Point(98, 178);
            btnCajeros.Name = "btnCajeros";
            btnCajeros.Size = new Size(144, 31);
            btnCajeros.TabIndex = 3;
            btnCajeros.Text = "Cajeros";
            btnCajeros.UseVisualStyleBackColor = true;
            btnCajeros.Click += btnCajeros_Click;
            // 
            // btnRecetas
            // 
            btnRecetas = new Button();
            btnRecetas.Location = new Point(98, 225);
            btnRecetas.Name = "btnRecetas";
            btnRecetas.Size = new Size(144, 31);
            btnRecetas.TabIndex = 4;
            btnRecetas.Text = "Recetas";
            btnRecetas.UseVisualStyleBackColor = true;
            btnRecetas.Click += btnRecetas_Click;
            // 
            // btnProduccion
            // 
            btnProduccion = new Button();
            btnProduccion.Location = new Point(98, 272);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(144, 31);
            btnProduccion.TabIndex = 5;
            btnProduccion.Text = "Producción";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 600);
            Controls.Add(btnProduccion);
            Controls.Add(btnRecetas);
            Controls.Add(btnCajeros);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(btnIngredientes);
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngredientes;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnCajeros;
        private Button btnRecetas;
        private Button btnProduccion;
    }
}
