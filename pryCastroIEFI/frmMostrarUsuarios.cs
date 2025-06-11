using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryCastroIEFI
{
    public partial class frmMostrarUsuarios : Form
    {
        public frmMostrarUsuarios()
        {
            InitializeComponent();
        }

        private void frmMostrarUsuarios_Load(object sender, EventArgs e)
        {
            //agregar grilla
            clsUsuarios usuarios = new clsUsuarios();
            DataTable mostrarUsuarios = usuarios.ObtenerUsuarios();
            if (mostrarUsuarios != null)
            {
                dgvMostrar.DataSource = mostrarUsuarios;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clsUsuarios usuario = new clsUsuarios();
            string Nombre = txtBuscarNombre.Text;

            DataTable Resultados = usuario.BuscarUsuario(Nombre);
            dgvMostrar.DataSource = Resultados;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
