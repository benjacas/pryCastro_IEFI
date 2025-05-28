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
    public partial class frmAgregarUsuarios : Form
    {
        public frmAgregarUsuarios()
        {
            InitializeComponent();
        }

        private void frmAgregarUsuarios_Load(object sender, EventArgs e)
        {
            //agregar combo
            string[] roles = new string[] { "Administrador", "Operador" };
            foreach (string rol in roles)
            {
                cmbRol.Items.Add(rol);
            }
            CargarUsuarios();
            
        }
        //agregar usuarios
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            clsUsuarios nuevoUsuario = new clsUsuarios();

            nuevoUsuario.Usuario = txtNombreUsuario.Text;
            nuevoUsuario.Clave= txtContraseña.Text;
            nuevoUsuario.Rol=cmbRol.Text;

            nuevoUsuario.RegistrarUsuarios(nuevoUsuario);
            CargarUsuarios();
            LimpiarControles();
        }


        public void CargarUsuarios()
        {
            //agregar grilla
            clsUsuarios usuarios = new clsUsuarios();
            DataTable mostrarUsuarios = usuarios.ObtenerUsuarios();
            if (mostrarUsuarios != null)
            {
                dgvMostrar.DataSource = mostrarUsuarios;
            }
        }
        //limpiar controles
        public void LimpiarControles()
        {
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            cmbRol.SelectedIndex = 0;
            
        }
    }
}
