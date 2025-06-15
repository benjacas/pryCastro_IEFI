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
    public partial class frmAgregarTarea : Form
    {
        public frmAgregarTarea()
        {
            InitializeComponent();
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            //MessageBox.Show("Cerrar Pestaña para actualizar tareas");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTareas nombreTarea = new clsTareas();
            string nuevoNombre = txtTarea.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Debe ingresar un nombre válido.");
                return;
            }

            nombreTarea.NombreParaAgregarTarea(nuevoNombre);
            txtTarea.Clear();
            this.Close();
        }
    }
}
