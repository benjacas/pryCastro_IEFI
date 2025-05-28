using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCastroIEFI
{
    internal class clsAuditoria
    {
        public DateTime inicioSesion;
        public DateTime finSesion;
        public string usuarioActual ;

        clsConexionBD conexion = new clsConexionBD();

        public void IniciarSesion(string usuario)
        {
         

            usuarioActual = usuario;
            inicioSesion = DateTime.Now;

            // Insertar registro en la tabla Auditoria
            string query = "INSERT INTO Auditoria (Usuario, FechaHoraInicio) VALUES (@usuario, @inicio)";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@usuario", usuarioActual);
            comando.Parameters.AddWithValue("@inicio", inicioSesion);
            conexion.EjecutarComando(comando);
        }

        public void CerrarSesion()
        {
            finSesion = DateTime.Now;
            TimeSpan duracion = finSesion - inicioSesion;

            string query = "UPDATE Auditoria SET FechaHoraFin = @fin, DuracionSegundos = @duracion " +
                   "WHERE Usuario = @usuario AND FechaHoraInicio = @inicio";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@fin", finSesion);
            comando.Parameters.AddWithValue("@duracion", (int)duracion.TotalSeconds);
            comando.Parameters.AddWithValue("@usuario", usuarioActual);
            comando.Parameters.AddWithValue("@inicio", inicioSesion);

            conexion.EjecutarComando(comando);

            MessageBox.Show("inicioSesion: " + inicioSesion.ToString());
            MessageBox.Show("finSesion: " + finSesion.ToString());
        }

        public void MostrarGrilla(DataGridView dgv)
        {
            string query = "SELECT Usuario, FechaHoraInicio, FechaHoraFin, DuracionSegundos FROM Auditoria";
            SqlCommand comando = new SqlCommand(query);
            DataTable dt = conexion.EjecutarConsulta(comando);

            if (dt != null)
            {
                dgv.DataSource = dt;
            }
        }

    }
}
