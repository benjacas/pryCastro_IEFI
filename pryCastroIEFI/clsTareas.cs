using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCastroIEFI
{
    internal class clsTareas
    {
        public string NombreTarea {  get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Detalle { get; set; }
        public string Comentario { get; set; }
        
        clsConexionBD conexion = new clsConexionBD();


        public void AgregarTarea(clsTareas nuevaTarea)
        {
            try
            {
                string query = "INSERT INTO Tareas (Nombre, Lugar, Fecha, Detalles, Comentarios) VALUES (@Tarea, @Lugar, @Fecha, @Detalles, @Comentarios)";
                SqlCommand comando = new SqlCommand(query);

                comando.Parameters.AddWithValue("@Tarea", nuevaTarea.NombreTarea);
                comando.Parameters.AddWithValue("@Lugar", nuevaTarea.Lugar);
                comando.Parameters.AddWithValue("@Fecha", nuevaTarea.Fecha);
                comando.Parameters.AddWithValue("@Detalles", nuevaTarea.Detalle);
                comando.Parameters.AddWithValue("@Comentarios", nuevaTarea.Comentario);

                conexion.EjecutarComando(comando);
                MessageBox.Show("Se guardó la tarea");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar tarea: " + ex.Message);
            }
        }

        public DataTable ObtenerTarea()
        {
            string query = "SELECT Id, Nombre, Lugar, Fecha, Detalles, Comentarios FROM Tareas";
            SqlCommand comando = new SqlCommand(query);

            return conexion.EjecutarConsulta(comando);
        }


    }
}
