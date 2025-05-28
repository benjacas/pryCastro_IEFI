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
        clsAuditoria auditoria=new clsAuditoria();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria v = new frmAuditoria();
            v.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            auditoria.CerrarSesion();

            Environment.Exit(0);
        }
    }
}
