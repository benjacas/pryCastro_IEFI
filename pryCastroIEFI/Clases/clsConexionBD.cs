using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCastroIEFI
{
    internal class clsConexionBD
    {
        /*
         Server=localhost: el servidor está en tu compu local.
        Database=Productos: conecta a la base llamada Productos.
        Trusted_Connection=True: usa la autenticación de Windows (no usuario/contraseña).
        */

        public string cadenaConexion = "Server=localhost;Database=Comercio;Trusted_Connection=True;TrustServerCertificate=True;";

        private SqlConnection conexion = new SqlConnection();//representa la conexion a la base de datos

        public string nombreBaseDeDatos;//variable donde se guarda el nombre de la base de datos

        //constructor
        public clsConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion); //se crea una nueva conexión con la cadena definida.
        }
        public void ConectarBD()
        {
            try
            {
                nombreBaseDeDatos = conexion.Database;
                conexion.Open();//Abre la conexion, si tiene un error, se va al catch

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }
        }


        /*
         Este método ejecuta comandos SQL que no devuelven resultados como:
         INSERT
         UPDATE
         DELETE
         instruccioes que solo modifica datoss
         */
        public void EjecutarComando(SqlCommand comando)
        {
            try
            {
                comando.Connection = conexion;//le dice al SqlCommand que use esa conexión
                conexion.Open();//abre la conexion con la base
                comando.ExecuteNonQuery(); //ejecuta el comando.ExecuteNonQuery() se usa para comandos que no devuelven filas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar comando: " + ex.Message);
            }
            finally
            {
                conexion.Close();//cierra conexion
            }
        }


        /*
         * Este método sirve para consultas que sí devuelven datos, como:

        SELECT * FROM Productos
        SELECT Nombre, Precio FROM Productos WHERE Precio > 100
        Devuelve un DataTable con los resultados.
         */
        public DataTable EjecutarConsulta(SqlCommand comando)
        {
            DataTable dt = new DataTable();//crea una tabla en memoria para guardar los resultados
            try
            {

                comando.Connection = conexion;//asocia el comando a la conexion
                conexion.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);//el SqlDataAdapter ejecuta la consulta y llena el DataTable con los datos obtenidos.
                adapter.Fill(dt);//devuelve la tabla con los resultados para que puedas mostrarlos, recorrerlos, etc
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return dt;
        }

    }
}

