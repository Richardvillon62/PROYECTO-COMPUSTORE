using DATOS_TSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULO_USUARIO
{
    public partial class FormModificarUsuario : Form
    {
        Dato_ts datos = new Dato_ts();
        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoBuscar.Text; 
            datos.BuscarDatosPorCorreoUsuario(correo);

            DataTable dato = datos.BuscarDatosPorCorreoUsuario(correo);

            if (dato.Rows.Count > 0)
            {
               
                txtId.Text = dato.Rows[0]["id_usuario"].ToString();
                txtNombre.Text = dato.Rows[0]["nombre_completo"].ToString();
                txtCorreo.Text = dato.Rows[0]["correo"].ToString();
                txtConfContrasena.Text = dato.Rows[0]["contrasena"].ToString();
            }
            else
            {
                MessageBox.Show("Correo no encontrado en los datos");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                datos.ModificarUsuario(int.Parse(txtId.Text), txtNombre.Text, txtCorreo.Text, txtConfContrasena.Text);
                MessageBox.Show("El dato del usuario ha sido actualizado correctamente"); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese los datos correctamente "); 
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
