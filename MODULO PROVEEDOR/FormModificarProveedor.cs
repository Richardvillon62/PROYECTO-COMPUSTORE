using DATOS_TSP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODULO_PROVEEDOR
{
    public partial class FormModificarProveedor : Form
    {
        Dato_ts datos = new Dato_ts();
        public FormModificarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoBuscar.Text;
            datos.BuscarDatosPorCorreoProveedor(correo);

            DataTable dato = datos.BuscarDatosPorCorreoProveedor(correo);

            if (dato.Rows.Count > 0)
            {

                txtId.Text = dato.Rows[0]["id_prooveedor"].ToString();
                txtNombre.Text = dato.Rows[0]["nombre_completo"].ToString();
                txtRuc.Text = dato.Rows[0]["ruc"].ToString();
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
                datos.ModificarProveedor(int.Parse(txtId.Text), txtNombre.Text, int.Parse(txtRuc.Text), txtCorreo.Text, txtConfContrasena.Text);
                MessageBox.Show("El dato del proveedor ha sido actualizado correctamente");
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
