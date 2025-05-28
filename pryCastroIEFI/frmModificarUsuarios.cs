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
    public partial class frmModificarUsuarios : Form
    {
        public frmModificarUsuarios()
        {
            InitializeComponent();
        }

        private void frmModificarUsuarios_Load(object sender, EventArgs e)
        {
            string[] roles = { "Administrador", "Operador" };
            foreach (string rol in roles)
            {
                cmbRol.Items.Add(rol);
            }
            CargarUsuario();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clsUsuarios nuevoUsuario = new clsUsuarios();

            nuevoUsuario.Id = Convert.ToInt32(txtIdUsuario.Text);
            nuevoUsuario.Usuario=txtContraseña.Text;
            nuevoUsuario.Clave = txtContraseña.Text;
            nuevoUsuario.Rol = cmbRol.Text;

            nuevoUsuario.ModificarUsuario(nuevoUsuario);

            CargarUsuario();
            LimpiarControles();
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

        public void LimpiarControles()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            cmbRol.SelectedIndex = 0;
            txtIdUsuario.Text = "";
        }
        
    }
}
