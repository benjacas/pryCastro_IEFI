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
    public partial class frmGestionUsuarios : Form
    {
        public frmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void agregarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarUsuarios AgregarUsuarios = new frmAgregarUsuarios();
            AgregarUsuarios.ShowDialog();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarUsuarios modificarUsuarios = new frmModificarUsuarios();
            modificarUsuarios.ShowDialog();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarUsuarios eliminarUsuarios = new frmEliminarUsuarios();
            eliminarUsuarios.ShowDialog();
        }

        private void verUsuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarUsuarios mostrarUsuarios = new frmMostrarUsuarios();
            mostrarUsuarios.ShowDialog();
        }
    }
}
