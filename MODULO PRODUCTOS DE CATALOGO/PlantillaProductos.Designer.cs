namespace MODULO_PRODUCTOS_DE_CATALOGO
{
    partial class PlantillaProductos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre_Producto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCarrito = new System.Windows.Forms.CheckBox();
            this.imagenProducto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre_Producto
            // 
            this.lblNombre_Producto.AutoSize = true;
            this.lblNombre_Producto.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre_Producto.Location = new System.Drawing.Point(180, 44);
            this.lblNombre_Producto.Name = "lblNombre_Producto";
            this.lblNombre_Producto.Size = new System.Drawing.Size(164, 21);
            this.lblNombre_Producto.TabIndex = 1;
            this.lblNombre_Producto.Text = "Nombre del producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(180, 73);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbCarrito);
            this.panel1.Controls.Add(this.imagenProducto);
            this.panel1.Controls.Add(this.lblNombre_Producto);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 178);
            this.panel1.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(180, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // cbCarrito
            // 
            this.cbCarrito.AutoSize = true;
            this.cbCarrito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCarrito.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrito.Image = global::MODULO_PRODUCTOS_DE_CATALOGO.Properties.Resources._8333853_add_to_cart_trolley_shopping_icon;
            this.cbCarrito.Location = new System.Drawing.Point(350, 3);
            this.cbCarrito.Name = "cbCarrito";
            this.cbCarrito.Size = new System.Drawing.Size(63, 48);
            this.cbCarrito.TabIndex = 4;
            this.cbCarrito.UseVisualStyleBackColor = true;
            this.cbCarrito.CheckedChanged += new System.EventHandler(this.cbCarrito_CheckedChanged);
            // 
            // imagenProducto
            // 
            this.imagenProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.imagenProducto.Location = new System.Drawing.Point(31, 16);
            this.imagenProducto.Name = "imagenProducto";
            this.imagenProducto.Size = new System.Drawing.Size(133, 142);
            this.imagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenProducto.TabIndex = 0;
            this.imagenProducto.TabStop = false;
            // 
            // PlantillaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PlantillaProductos";
            this.Size = new System.Drawing.Size(424, 178);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblNombre_Producto;
        public System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.CheckBox cbCarrito;
        public System.Windows.Forms.Label lblDescripcion;
    }
}
