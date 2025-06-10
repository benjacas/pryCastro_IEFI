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


        public void AgregarTarea(List<clsTareas> listaTareas)
        {
            try
            {
                foreach (clsTareas tarea in listaTareas)
                {
                    string query = "INSERT INTO Tareas (Nombre, Lugar, Fecha) VALUES (@Nombre, @Lugar, @Fecha)";
                    SqlCommand comando = new SqlCommand(query);
                    comando.Parameters.AddWithValue("@Nombre", tarea.NombreTarea);
                    comando.Parameters.AddWithValue("@Lugar", tarea.Lugar);
                    comando.Parameters.AddWithValue("@Fecha", tarea.Fecha);

                    conexion.EjecutarComando(comando);
                }

                MessageBox.Show("Tareas guardadas correctamente.");

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar tarea: " + ex.Message);
            }
        }


        public void GuardarDetallesYAsignar(string uniforme, string licencia, string reclamo, string comentario)
        {
           
            string queryDetalle = "INSERT INTO DetallesTarea (Uniforme, Licencia, Reclamo, Comentario) " +
                                  "VALUES (@Uniforme, @Licencia, @Reclamo, @Comentario); SELECT SCOPE_IDENTITY();";

            SqlCommand comando = new SqlCommand(queryDetalle);
            comando.Parameters.AddWithValue("@Uniforme", uniforme);
            comando.Parameters.AddWithValue("@Licencia", licencia);
            comando.Parameters.AddWithValue("@Reclamo", reclamo);
            comando.Parameters.AddWithValue("@Comentario", comentario);

            
            DataTable dt = conexion.EjecutarConsulta(comando);
            int idDetalle = Convert.ToInt32(dt.Rows[0][0]);

          
            string queryAsignar = "UPDATE Tareas SET IdDetalle = @IdDetalle WHERE IdDetalle IS NULL";
            SqlCommand comandoAsignar = new SqlCommand(queryAsignar);
            comandoAsignar.Parameters.AddWithValue("@IdDetalle", idDetalle);
            conexion.EjecutarComando(comandoAsignar);

            MessageBox.Show("Detalles guardados y asignados a las tareas.");
        }

        public DataTable ObtenerTareasConDetalles()
        {
            string query = @"
        SELECT 
            t.Id,
            t.Nombre,
            t.Lugar,
            t.Fecha,
            d.Uniforme,
            d.Licencia,
            d.Reclamo,
            d.Comentario
        FROM 
            Tareas t
        LEFT JOIN 
            DetallesTarea d ON t.IdDetalle = d.Id";

            SqlCommand comando = new SqlCommand(query);
            return conexion.EjecutarConsulta(comando);
        }

        public DataTable BuscarTareasPorNombre(string nombre)
        {
            string query = @"
                SELECT 
                    t.Id,
                    t.Nombre,
                    t.Lugar,
                    t.Fecha,
                    d.Uniforme,
                    d.Licencia,
                    d.Reclamo,
                    d.Comentario
                FROM 
                    Tareas t
                LEFT JOIN 
                    DetallesTarea d ON t.IdDetalle = d.Id
                WHERE 
                    t.Nombre LIKE @nombre";

            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            return conexion.EjecutarConsulta(comando);
        }

        public void CargarNombresDeTarea(ComboBox combo)
        {
            string query = "SELECT Nombre FROM NombreTareas";
            SqlCommand comando = new SqlCommand(query);
            DataTable tabla = conexion.EjecutarConsulta(comando);

            combo.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                combo.Items.Add(fila["Nombre"].ToString());
            }
        }

        public void NombreParaAgregarTarea (string nuevoNombre)
        {
            string query = "INSERT INTO NombreTareas (Nombre) VALUES (@nombre)";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@nombre", nuevoNombre);

            try
            {
                conexion.EjecutarComando(comando);
                MessageBox.Show("Nombre de tarea agregado correctamente.");
               
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Violación de restricción UNIQUE
                    MessageBox.Show("Ese nombre ya existe.");
                else
                    MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        public void CargarNombresDeLugares(ComboBox combo)
        {
            string query = "SELECT Nombre FROM NombreLugares";
            SqlCommand comando = new SqlCommand(query);
            DataTable tabla = conexion.EjecutarConsulta(comando);

            combo.Items.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                combo.Items.Add(fila["Nombre"].ToString());
            }
        }

        public void NombreParaAgregarLugares(string nuevoLugar)
        {
            string query = "INSERT INTO NombreLugares (Nombre) VALUES (@nombre)";
            SqlCommand comando = new SqlCommand(query);
            comando.Parameters.AddWithValue("@nombre", nuevoLugar);

            try
            {
                conexion.EjecutarComando(comando);
                MessageBox.Show("Nombre de Lugar agregado correctamente.");

            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // Violación de restricción UNIQUE
                    MessageBox.Show("Ese Lugar ya existe.");
                else
                    MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

    }
}
