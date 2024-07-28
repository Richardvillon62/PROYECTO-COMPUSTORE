using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_COMPUSTORE
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void contenedores(Form conten)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = conten;
            conten.TopLevel = false;
            conten.FormBorderStyle = FormBorderStyle.None;
            conten.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(conten);
            panelContenedor.Tag = conten;
            conten.BringToFront();
            conten.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            contenedores(new FormListaCliente());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            contenedores(new FormListaProveedor());
        }

        private void BtnEmpresa_Click(object sender, EventArgs e)
        {
            contenedores(new FormListaEmpresa());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            contenedores(new FormListaProductos());
        }
    }
}
