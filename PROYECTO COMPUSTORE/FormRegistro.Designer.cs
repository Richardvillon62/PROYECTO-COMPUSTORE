namespace MODULO_USUARIO
{
    partial class FormRegistro
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbProveedor = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.lblUsuarioTipo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Correo electronico:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(295, 91);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(305, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(295, 162);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(305, 20);
            this.txtCorreo.TabIndex = 7;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(295, 203);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(305, 20);
            this.txtContraseña.TabIndex = 13;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre completo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(295, 124);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(305, 20);
            this.txtNombreUsuario.TabIndex = 16;
            this.txtNombreUsuario.TextChanged += new System.EventHandler(this.txtNombreUsuario_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(114, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo de usuario:";
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCliente.Location = new System.Drawing.Point(290, 244);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(62, 18);
            this.rbCliente.TabIndex = 18;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Cliente";
            this.rbCliente.UseVisualStyleBackColor = true;
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpresa.Location = new System.Drawing.Point(290, 290);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(150, 18);
            this.rbEmpresa.TabIndex = 19;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa de transporte";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProveedor.Location = new System.Drawing.Point(290, 267);
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Size = new System.Drawing.Size(81, 18);
            this.rbProveedor.TabIndex = 20;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor";
            this.rbProveedor.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(290, 313);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(99, 18);
            this.rbAdmin.TabIndex = 21;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioTipo
            // 
            this.lblUsuarioTipo.AutoSize = true;
            this.lblUsuarioTipo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioTipo.Location = new System.Drawing.Point(14, 340);
            this.lblUsuarioTipo.Name = "lblUsuarioTipo";
            this.lblUsuarioTipo.Size = new System.Drawing.Size(15, 22);
            this.lblUsuarioTipo.TabIndex = 22;
            this.lblUsuarioTipo.Text = ".";
            this.lblUsuarioTipo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::PROYECTO_TELESHOPPING.Properties.Resources.cierre;
            this.pictureBox3.Location = new System.Drawing.Point(648, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(269, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Registrar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(702, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblUsuarioTipo);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbProveedor);
            this.Controls.Add(this.rbEmpresa);
            this.Controls.Add(this.rbCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(702, 448);
            this.MinimumSize = new System.Drawing.Size(702, 448);
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarUsuario";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbProveedor;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Label lblUsuarioTipo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

