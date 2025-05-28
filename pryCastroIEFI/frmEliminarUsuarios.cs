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
    public partial class frmEliminarUsuarios : Form
    {
        public frmEliminarUsuarios()
        {
            InitializeComponent();
        }

        private void frmEliminarUsuarios_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione un producto de la lista para eliminar.");
            CargarUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clsUsuarios nuevoUsuario = new clsUsuarios();

            if (dgvMostrar.SelectedRows.Count == 0)
            {
                btnEliminar.Enabled = false;
                
                return;
            }
            else
            {
                btnEliminar.Enabled = true;
                DataGridViewRow seleccion = dgvMostrar.SelectedRows[0];
                string nombreUsuario = seleccion.Cells["Usuario"].Value.ToString();
                nuevoUsuario.EliminarUsuario(nombreUsuario);

                CargarUsuario();
            }

            
        }

        public void CargarUsuario()
        {
            //agregar grilla
            clsUsuarios usuarios = new clsUsuarios();
            DataTable mostrarUsuarios = usuarios.ObtenerUsuarios();
            if (mostrarUsuarios != null)
            {
                dgvMostrar.DataSource = mostrarUsuarios;
            }
        }

        
    }
}
