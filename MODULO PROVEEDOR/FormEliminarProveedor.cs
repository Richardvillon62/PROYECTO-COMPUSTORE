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
    public partial class FormEliminarProveedor : Form
    {
        /*Instanciamos la clase con la conexion para hacer uso de los metodos*/
        Dato_ts datos = new Dato_ts();
        public FormEliminarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            /*se crea una variable para usarla en la tabla por medio de parametro y en el texbox*/
            string correo = txtCorreoBuscar.Text;
            /*se llama la tabla y pasamos la conexion con el metodo de buscar por correo*/
            DataTable dato = datos.BuscarDatosPorCorreoProveedor(correo);

            /*recorremos la tabla hasta encontrar el dato especificado*/
            if (dato.Rows.Count > 0)
            {
                /*si se cumple la funcion se visualiza en los texbox especificados*/
                txtId.Text = dato.Rows[0]["id_proveedor"].ToString();
                txtNombre.Text = dato.Rows[0]["nombre_completo"].ToString();
                txtRuc.Text = dato.Rows[0]["ruc"].ToString();
                txtCorreo.Text = dato.Rows[0]["correo"].ToString();
                txtConfContrasena.Text = dato.Rows[0]["contrasena"].ToString();
            }
            /*caso contrario se envia un mensaje*/
            else
            {
                MessageBox.Show("Correo no encontrado en los datos");
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            /*Control de exepciones */
            try
            {
                /*se llama el metodo con parametro*/
                datos.EliminarProveedor(int.Parse(txtIngreseId.Text));
                MessageBox.Show("Se ha eliminado correctamente");
            }
            catch (FormatException)
            {

                MessageBox.Show("ID no encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEliminarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
