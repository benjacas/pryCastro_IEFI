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
    public partial class frmPrincipal : Form
    {
        private clsAuditoria Auditoria;
        private clsUsuarios UsuarioLogin;
        int segundosTranscurridos = 0;

        public frmPrincipal(clsAuditoria sesionCompartida, clsUsuarios usuarioLogin)
        {
            InitializeComponent();
            Auditoria = sesionCompartida;
            UsuarioLogin = usuarioLogin;
        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmRegistrarTareas abrirTareas = new frmRegistrarTareas(UsuarioLogin);
            abrirTareas.ShowDialog();
        }

        private void btnAuditoria_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            frmGestionUsuarios usuarios = new frmGestionUsuarios();
            usuarios.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Sesion Cerrada");

            tmrTemporizador.Stop();
            Auditoria.CerrarSesion();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            clsUsuarios Usuarios = new clsUsuarios();
            string nombreUsuario = UsuarioLogin.Usuario;
            string contraseña = UsuarioLogin.Clave;

            string rol = Usuarios.ObtenerRol(nombreUsuario, contraseña);
            if (rol == "Operador")
            {
                btnAuditoria.Visible = false;
                btnGestionUsuarios.Visible = false;
            }
            tmrTemporizador.Interval = 1000; // 1 segundo
            tmrTemporizador.Tick += tmrTemporizador_Tick;
            tmrTemporizador.Start();


            toolStripStatusLabel1.Text = "Hola " + nombreUsuario;
        }

        private void tmrTemporizador_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;

            // Podés convertirlo a formato hh:mm:ss:
            TimeSpan tiempo = TimeSpan.FromSeconds(segundosTranscurridos);
            StatusStripTiempo.Text = "Tiempo Transcurrido " + tiempo.ToString(@"hh\:mm\:ss");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmMostrarTareas abrirTareas = new frmMostrarTareas();
            abrirTareas.ShowDialog();
        }
    }
}
