using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_TSP
{
    public class Dato_ts 
    {
        /*Se crea una variable tipo string para pasar la conexion de nuestro servidor */
        string con = "Data Source=localhost,1433\\MSSQLSERVER01;Initial Catalog=PROYECTO_COMPUSTORE;User ID=sa;Password=LzTMmTrOv8x5BMNj9pmx";
        /*Metodo static para poder intanciar la clase a otro proyecto*/
        private static Dato_ts datos_compustore = new Dato_ts(); 
        /*Constructor*/
        public Dato_ts() { }
        /*Metodo static que retorna toda la clase*/
        public static Dato_ts getObject()
        {
            return datos_compustore;//comentario
        }

        /*SE CREA UNA IMPORTACION DE CONEXION POR CADA METODO DE CADA CLASE*/

        /*Metodo StoredProcedure con parametros para insertar usuario*/
        public void InsertarUsuario( string nombre, string correo, string contrasena)
        {            
            String conet = "SP_RegistrarUsuario";
            /*llamamos la conexion de nuestro servidor*/
            using (SqlConnection connection = new SqlConnection(con)) 
            {
                using (SqlCommand command = new SqlCommand(conet, connection))
                {
                    /*se especifica los procediminetos almacenados para insertar usuario*/
                    command.CommandType = CommandType.StoredProcedure;                  
                    command.Parameters.AddWithValue("@nombre_completo", nombre); 
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    /*Abrimos la conexion de la base de datos y se ejecuta*/
                    connection.Open(); 
                    command.ExecuteNonQuery(); 
                }
            }
        }
        /*Metodo StoredProcedure con parametros para modificar usuario */
        public void ModificarUsuario( int id, string nombre, string correo, string contrasena)
        { 
            String conet = "SP_ModificarUsuario";
            /*llamamos la conexion de nuestro servidor*/
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(conet, connection))
                {
                    /*se especifica los procediminetos almacenados para modificar usuario*/
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    /*Abrimos la conexion de la base de datos y se ejecuta*/
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /*Metodo StoredProcedure con parametros para buscar usuario */
        public DataTable BuscarDatosPorCorreoUsuario(string correoBuscado)
        {
            DataTable datos = new DataTable();

            /*llamamos la conexion de nuestro servidor*/
            using (SqlConnection connection = new SqlConnection(con))
            {
                /*se especifica los procediminetos almacenados para busar al usuario por correo*/
                SqlCommand command = new SqlCommand("SP_BuscarCorreoUsuario", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Correo", correoBuscado);

                try
                {
                    /*Abre la conexion*/
                    connection.Open();
                    /*se ejecuta SqlAdapter para llenar la tabla con los datos almacenados*/
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datos);
                    return datos;
                }
                /*se envia un excepcion si hubo algun problema al buscar los datos*/
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar los datos: " + ex.Message);
                    return datos;
                }
            }
        }

        /*Metodo StoredProcedure con parametro para eliminar usuario */
        public void EliminarUsuario(int id)
        { 
            String conet = "SP_EliminarUsuario";
            /*llamamos la conexion de nuestro servidor*/
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(conet, connection))
                {
                    /*se especifica los procediminetos almacenados para eliminar usuario*/
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);
                    /*Abrimos la conexion de la base de datos y se ejecuta*/
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    

    /*CONECTAMOS AL PROVEEDOR*/

    public void InsertarProveedor(string nombre, int ruc, string correo, string contrasena)
    {
        String conet = "SP_RegistrarProveedor";
        /*llamamos la conexion de nuestro servidor*/
        using (SqlConnection connection = new SqlConnection(con))
        {
            using (SqlCommand command = new SqlCommand(conet, connection))
            {
                /*se especifica los procediminetos almacenados para insertar proveedor*/
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre_completo", nombre);
                command.Parameters.AddWithValue("@ruc", ruc);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@contrasena", contrasena);
                /*Abrimos la conexion de la base de datos y se ejecuta*/
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
    /*Metodo StoredProcedure con parametros para modificar proveedor */
    public void ModificarProveedor(int id, string nombre, int ruc, string correo, string contrasena)
    {
        String conet = "SP_ModificarProveedor";
        /*llamamos la conexion de nuestro servidor*/
        using (SqlConnection connection = new SqlConnection(con))
        {
            using (SqlCommand command = new SqlCommand(conet, connection))
            {
                /*se especifica los procediminetos almacenados para modificar proveedor*/
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nombre", nombre);
                command.Parameters.AddWithValue("@ruc", ruc);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@contrasena", contrasena);
                /*Abrimos la conexion de la base de datos y se ejecuta*/
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    /*Metodo StoredProcedure con parametros para buscar proveedor */
    public DataTable BuscarDatosPorCorreoProveedor(string correoBuscado)
    {
        DataTable datos = new DataTable();

        /*llamamos la conexion de nuestro servidor*/
        using (SqlConnection connection = new SqlConnection(con))
        {
            /*se especifica los procediminetos almacenados para busar al proveedor por correo*/
            SqlCommand command = new SqlCommand("SP_BuscarDatosCorreoProveedor", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Correo", correoBuscado);

            try
            {
                /*Abre la conexion*/
                connection.Open();
                /*se ejecuta SqlAdapter para llenar la tabla con los datos almacenados*/
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(datos);
                return datos;
            }
            /*se envia un excepcion si hubo algun problema al buscar los datos*/
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar los datos: " + ex.Message);
                return datos;
            }
        }
    }

    /*Metodo StoredProcedure con parametro para eliminar proveedor */
    public void EliminarProveedor(int id)
    {
        String conet = "SP_EliminarProveedor";
        /*llamamos la conexion de nuestro servidor*/
        using (SqlConnection connection = new SqlConnection(con))
        {
            using (SqlCommand command = new SqlCommand(conet, connection))
            {
                /*se especifica los procediminetos almacenados para eliminar proveedor*/
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                /*Abrimos la conexion de la base de datos y se ejecuta*/
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

        /*CONECTAMOS AL CATALOGO DE PRODUCTOS*/

        public void InsertarCatalogo(string nombrep,  string desc, byte imagen)
        {
            String conet = "SP_RegistrarCatalogoProductos";
            /*llamamos la conexion de nuestro servidor*/
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(conet, connection))
                {
                    /*se especifica los procediminetos almacenados para insertar catalogo de productos*/
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombre_producto", nombrep);
                    command.Parameters.AddWithValue("@descripcion", desc);
                    command.Parameters.AddWithValue("@foto", imagen);
                    
                    /*Abrimos la conexion de la base de datos y se ejecuta*/
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
