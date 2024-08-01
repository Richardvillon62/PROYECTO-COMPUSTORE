using DATOS_TSP;
using Menssage_Exception;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/*GRUPO D*/
namespace MODULO_PRODUCTOS_DE_CATALOGO
{
    public partial class FormListaProductos : Form
    {
        private DataRow selectedDataRow;
        /*Llamamos la clase que tiene la conexion de datos*/
        Dato_ts datos = new Dato_ts();
        public FormListaProductos()
        {
            InitializeComponent();
        }
        /*metodo para actualizar rl campo de imagen y lea para string*/
        private void ActualizarImagenEnBaseDeDatos(int idUsuario, byte[] imagenBytes)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"UPDATE productos SET imagen = @Imagen WHERE id_producto = @ID", datos.AbrirConexion()))
                {
                    command.Parameters.AddWithValue("@Imagen", (object)imagenBytes ?? DBNull.Value);
                    command.Parameters.AddWithValue("@ID", idUsuario);
                    /*abrimos la conexion*/
                    datos.AbrirConexion();
                    command.ExecuteNonQuery();
                }
            }
            catch (ExcepcionActualizarValorEnBaseDeDatos ex)
            {
                MessageBox.Show($"Error al actualizar la imagen en la base de datos: {ex.Message}");
            }
        }
        private void ActualizarValorEnBaseDeDatos(int idUsuario, string columna, string nuevoValor)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"UPDATE productos SET {columna} = @NuevoValor WHERE id_producto = @ID", datos.AbrirConexion()))
                {
                    command.Parameters.AddWithValue("@NuevoValor", nuevoValor);
                    command.Parameters.AddWithValue("@ID", idUsuario);

                    datos.AbrirConexion();
                    command.ExecuteNonQuery();
                }
            }
            catch (ExcepcionActualizarValorEnBaseDeDatos ex)
            {
                MessageBox.Show($"Error al actualizar en la base de datos: {ex.Message}");
            }
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            try
            {
                dataProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataProducto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                /*agregamos nuestro metodo para visualizarlo en el dataGridView*/
                dataProducto.DataSource = datos.ListaDeProductos();
                dataProducto.CellEndEdit += dataProducto_CellEndEdit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            /*cierra ventana */
            this.Close();
        }

        private void dataProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*seleciona los campos de la tabla*/
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataProducto.Rows[e.RowIndex];
                DataRowView selectedRowView = (DataRowView)selectedRow.DataBoundItem;
                selectedDataRow = selectedRowView.Row;

                BtnModificar.Enabled = true;
            }
        }

        private void dataProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            /*seleciona y edita en la tabla*/
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow editedRow = dataProducto.Rows[e.RowIndex];
                DataGridViewCell editedCell = editedRow.Cells[e.ColumnIndex];

                // Obtener la columna actual y el nombre de la columna.
                string columnName = dataProducto.Columns[e.ColumnIndex].Name;

                // Obtener la clave primaria de la fila.
                int idUsuario = Convert.ToInt32(editedRow.Cells["id_producto"].Value);

                // Obtener el nuevo valor editado por el usuario.
                string newValue = editedCell.Value.ToString();

                // se llama al metodo para para actualizar
                ActualizarValorEnBaseDeDatos(idUsuario, columnName, newValue);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            /*seleciona la tabla y actualiza los datos con el metodo de actualizar */
            if (selectedDataRow != null)
            {

                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "id_proveedor", selectedDataRow["id_proveedor"].ToString());
                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "nombre_producto", selectedDataRow["nombre_producto"].ToString());
                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "descripcion", selectedDataRow["descripcion"].ToString());
                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "cantidad", selectedDataRow["cantidad"].ToString());
                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "precio", selectedDataRow["precio"].ToString());
                ActualizarValorEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), "total", selectedDataRow["total"].ToString());

                // Obtiene la imagen en formato de array de bytes.
                byte[] imagenBytes = null;
                if (selectedDataRow["imagen"] != DBNull.Value)
                {
                    imagenBytes = (byte[])selectedDataRow["imagen"];
                }

                // Actualiza el campo de imagen en la base de datos.
                ActualizarImagenEnBaseDeDatos(Convert.ToInt32(selectedDataRow["id_producto"]), imagenBytes);

                // refresca la tabla 
                dataProducto.DataSource = datos.ListaDeProductos();
                // mensaje de que se realizo los campos 
                MessageBox.Show("Datos modificados correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en Modificar.");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*selecciona y se llama el metodo para eliminar la fila seleccionada*/
            if (selectedDataRow != null)
            {
                int idUsuario = Convert.ToInt32(selectedDataRow["id_producto"]);

                // Eliminar el usuario de la base de datos.
                datos.EliminarProducto(idUsuario);
                // Eliminar la fila seleccionada del DataGridView.
                dataProducto.Rows.Remove(dataProducto.CurrentRow);

                MessageBox.Show("Usuario eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de hacer clic en Eliminar.");
            }
        }

        private void dataProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
