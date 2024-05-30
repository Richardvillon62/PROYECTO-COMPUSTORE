using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS_TSP;
using MODULO_USUARIO;

namespace PROYECTO_TELESHOPPING
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal f = new FormMenuPrincipal();
            f.Show();
             

        }

        public static string getdata() { return "hola"; }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
