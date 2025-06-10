using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCastroIEFI
{
    public class clsUsuarios
    {
        private clsConexionBD conexion = new clsConexionBD();

        public int Id { get; set; } 
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; } 

        public bool VerificarLogin(string usuario, string contraseña)
        {
            string query = "SELECT COUNT (*) FROM Usuarios WHERE Usuario =@Usuario AND Clave = @Clave";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Usuario", usuario);
            comando.Parameters.AddWithValue("@Clave", contraseña);

            DataTable dt = conexion.EjecutarConsulta(comando);
            return Convert.ToInt32(dt.Rows[0][0]) > 0;

        }

        

        public string ObtenerRol(string usuario, string contraseña)
        {
            //CODIGO DEL ROL
            string rol = "";
            try
            {
                

                string query = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Clave", contraseña);

                DataTable dt = conexion.EjecutarConsulta(comando);

                if (dt.Rows.Count > 0)
                {
                    rol = dt.Rows[0]["Rol"].ToString();

                }

                return rol;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar usuario:" + ex.Message);
            }

            return rol;
        }




        public void RegistrarUsuarios(clsUsuarios usuario)
        {
            try
            {
                string query = "INSERT INTO Usuarios (Usuario, Clave, Rol) VALUES (@Usuario, @Clave, @Rol)";
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                comando.Parameters.AddWithValue("@Rol", usuario.Rol);

                conexion.EjecutarComando(comando);
                MessageBox.Show("Usuario agregado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }

        }
        

        public void EliminarUsuario(string nombreUsuario)
        {
            try
            {
                string query = "DELETE FROM Usuarios WHERE Usuario = @nombreUsuario";//Arma una sentencia SQL para eliminar un nombre específico
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);//usa parámetros para prevenir inyecciones SQL

                conexion.EjecutarComando(comando);//elimina el registro
                MessageBox.Show("Usuario eliminado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        public void ModificarUsuario(clsUsuarios usuario )
        {
            try
            {
                string query = "UPDATE Usuarios SET Usuario = @Usuario, Clave = @Clave, Rol = @Rol WHERE Id = @Id";
                SqlCommand comando = new SqlCommand(query);
                comando.Parameters.AddWithValue("@Id", usuario.Id);
                comando.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                comando.Parameters.AddWithValue("@Clave", usuario.Clave);
                comando.Parameters.AddWithValue("@Rol", usuario.Rol);

                conexion.EjecutarComando(comando);
                MessageBox.Show("Usuario modificado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar usuario: " + ex.Message);
            }
        }

        public DataTable BuscarUsuario(string texto)
        {
            string query = "SELECT Id, Usuario, Rol FROM Usuarios WHERE Usuario LIKE @Texto";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@Texto", "%" + texto + "%");
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable ObtenerUsuarios()
        {
            string query = "SELECT Id, Usuario, Rol FROM Usuarios";
            SqlCommand comando = new SqlCommand(query);
            return conexion.EjecutarConsulta(comando);
        }
       
    }
}
