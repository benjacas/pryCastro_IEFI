using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCastroIEFI
{
    public class clsAuditoria
    {
        DateTime inicioSesion { get; set; }
        public DateTime finSesion { get; set; }
        public string usuarioActual;

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
            TimeSpan diferencia = finSesion - inicioSesion;
            TimeSpan duracion = new TimeSpan(diferencia.Hours,diferencia.Minutes,diferencia.Seconds);

            string query = "UPDATE Auditoria SET FechaHoraFin = @fin, Duracion = @duracion " +
                   "WHERE Usuario = @usuario AND FechaHoraInicio = @inicio";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@fin", finSesion);
            comando.Parameters.AddWithValue("@duracion", duracion);
            comando.Parameters.AddWithValue("@usuario", usuarioActual);
            comando.Parameters.AddWithValue("@inicio", inicioSesion);

            conexion.EjecutarComando(comando);
        }

        public void MostrarGrilla(DataGridView dgv)
        {
            string query = "SELECT Usuario, FechaHoraInicio, FechaHoraFin, Duracion FROM Auditoria";
            SqlCommand comando = new SqlCommand(query);
            DataTable dt = conexion.EjecutarConsulta(comando);

            if (dt != null)
            {
                dgv.DataSource = dt;
            }
        }

    }
}
