using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCastroIEFI
{
    public partial class frmMostrarTareas : Form
    {
        public frmMostrarTareas()
        {
            InitializeComponent();
        }

        private void frmMostrarTareas_Load(object sender, EventArgs e)
        {
            clsTareas tareas = new clsTareas();
            DataTable tabla = tareas.ObtenerTareasConDetalles();

            dgvMostrar.DataSource = tabla;
        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombre.Text.Trim();
            clsTareas gestor = new clsTareas();
            dgvMostrar.DataSource = gestor.BuscarTareasPorNombre(nombre);
        }
    }
}
