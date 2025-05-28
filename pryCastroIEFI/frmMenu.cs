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
    public partial class frmMenu : Form
    {
        private clsAuditoria Auditoria;
        
        public frmMenu(clsAuditoria sesionCompartida)
        {
            InitializeComponent();
            Auditoria = sesionCompartida;
        }
        
        frmGestionUsuarios usuarios = new frmGestionUsuarios();
        

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria auditoria = new frmAuditoria();
            auditoria.ShowDialog();
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            usuarios.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
            MessageBox.Show("Sesion Cerrada");

            
            Auditoria.CerrarSesion();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            //string usuario= auditoria.usuarioActual;
            //auditoria.IniciarSesion(usuario);
        }
    }
}
