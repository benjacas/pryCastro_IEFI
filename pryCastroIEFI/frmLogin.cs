using Guna.UI2.WinForms;
using pryCastroIEFI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestionInventario2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        clsUsuarios Usuarios = new clsUsuarios();
        clsAuditoria Auditoria = new clsAuditoria();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
   
            string usuarioActual = txtUsuario.Text;
            string contraseñaActual = txtContraseña.Text;
            Usuarios.Usuario = usuarioActual;
            Usuarios.Clave = contraseñaActual;

            try
            {
                if (Usuarios.VerificarLogin(usuarioActual, contraseñaActual))
                {
                  

                    Auditoria.IniciarSesion(usuarioActual);

                    
                    MessageBox.Show("Bienvenido " + usuarioActual);
                    
                    frmMenu v = new frmMenu(Auditoria,Usuarios);
                    
                    v.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }
    }
}
