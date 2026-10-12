/*
 * Universidad: Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: III Cuatrimestre 2026
 * Proyecto: Proyecto #1 - Distribuidora Gourmet
 * Descripción: Sistema de gestión de ingredientes, productos,
 * recetas, clientes, cajeros, producción y ventas.
 * Estudiante: Maykel Gonzalez Benavides
 * Fecha: 11/10/2026
 */

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
            btnClientes = new Button();
            btnCajeros = new Button();
            btnRecetas = new Button();
            btnProduccion = new Button();
            btnVentas = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngredientes
            // 
            btnIngredientes.Location = new Point(25, 21);
            btnIngredientes.Name = "btnIngredientes";
            btnIngredientes.Size = new Size(160, 40);
            btnIngredientes.TabIndex = 0;
            btnIngredientes.Text = "Ingredientes";
            btnIngredientes.UseVisualStyleBackColor = true;
            btnIngredientes.Click += btnIngredientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(25, 76);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(160, 40);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(25, 131);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(160, 40);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnCajeros
            // 
            btnCajeros.Location = new Point(25, 186);
            btnCajeros.Name = "btnCajeros";
            btnCajeros.Size = new Size(160, 40);
            btnCajeros.TabIndex = 3;
            btnCajeros.Text = "Cajeros";
            btnCajeros.UseVisualStyleBackColor = true;
            btnCajeros.Click += btnCajeros_Click;
            // 
            // btnRecetas
            // 
            btnRecetas.Location = new Point(25, 241);
            btnRecetas.Name = "btnRecetas";
            btnRecetas.Size = new Size(160, 40);
            btnRecetas.TabIndex = 4;
            btnRecetas.Text = "Recetas";
            btnRecetas.UseVisualStyleBackColor = true;
            btnRecetas.Click += btnRecetas_Click;
            // 
            // btnProduccion
            // 
            btnProduccion.Location = new Point(25, 296);
            btnProduccion.Name = "btnProduccion";
            btnProduccion.Size = new Size(160, 40);
            btnProduccion.TabIndex = 5;
            btnProduccion.Text = "Producción";
            btnProduccion.UseVisualStyleBackColor = true;
            btnProduccion.Click += btnProduccion_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(25, 351);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(160, 40);
            btnVentas.TabIndex = 6;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.DistGourmetLogo;
            pictureBox1.Location = new Point(205, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(555, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(pictureBox1);
            Controls.Add(btnVentas);
            Controls.Add(btnProduccion);
            Controls.Add(btnRecetas);
            Controls.Add(btnCajeros);
            Controls.Add(btnClientes);
            Controls.Add(btnProductos);
            Controls.Add(btnIngredientes);
            MaximumSize = new Size(800, 450);
            MinimumSize = new Size(800, 450);
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngredientes;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnCajeros;
        private Button btnRecetas;
        private Button btnProduccion;
        private Button btnVentas;
        private PictureBox pictureBox1;
    }
}
