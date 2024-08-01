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

namespace MODULO_USUARIO
{
    public partial class FormRegistarUsuario : Form
    {
        Dato_ts datos = new Dato_ts();
        public FormRegistarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //datos.InsertarUsuario(txtNombre.Text, txtCorreo.Text, txtContraseña.Text);
                MessageBox.Show("Se ha insertado correctamente los datos");
            }
            catch (FormatException)
            {
                MessageBox.Show("Se ha producido un error al insertar los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
