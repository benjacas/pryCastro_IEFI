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
    public partial class frmRegistrarTareas : Form
    {
        public frmRegistrarTareas()
        {
            InitializeComponent();
        }

        

        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void frmRegistrarTareas_Load(object sender, EventArgs e)
        {

            string[] vecTareas = new string[] { "Auditoría", "Consultas", "Inspección", "Reclamos", "Visita" };
            string[] vecLugar = new string[] { "Empresa", "Servicio", "Oficina" };
            string[] vecColumnas = new string[] { "Tarea", "Lugar", "Fecha" };


            foreach (string tareas in vecTareas)
            {
                cmbTarea.Items.Add(tareas);
            }

            foreach (string lugar in vecLugar)
            {
                cmbLugar.Items.Add(lugar);
            }

            foreach (string columnas in vecColumnas)
            {
                dgvMostrar.Columns.Add("col", columnas);
            }

            dtFecha.MaxDate = DateTime.Now;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string tarea = cmbTarea.Text;
            string fecha = dtFecha.Text;
            string lugar = cmbLugar.Text;

            if (!string.IsNullOrEmpty(tarea) && !string.IsNullOrEmpty(fecha) && !string.IsNullOrEmpty(lugar))
            {
                dgvMostrar.Rows.Add(tarea, lugar, fecha);
                cmbLugar.SelectedIndex = -1;
                cmbTarea.SelectedIndex = -1;

            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            frmAgregarTarea abrirTarea = new frmAgregarTarea();
            abrirTarea.ShowDialog();
        }

        private void btnAgregarLugar_Click(object sender, EventArgs e)
        {
            frmAgregarLugar abrirLugar = new frmAgregarLugar();
            abrirLugar.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTareas nuevaTarea = new clsTareas();
            string insumo = "Insumo";
            string estudio = "Estudio";
            string vacacion = "Vacación";
            string recibo = "Recibo";
            string salario = "Salario";

            if (chkInsumo.Checked)
            {
                nuevaTarea.Detalle = insumo;
            }
            if (chkEstudio.Checked)
            {
                nuevaTarea.Detalle = estudio;
            }
            if (chkRecibo.Checked)
            {
                nuevaTarea.Detalle = recibo;
            }
            if (chkVacacion.Checked)
            {
                nuevaTarea.Detalle = vacacion;
            }
            if (chkSalario.Checked)
            {
                nuevaTarea.Detalle = salario;
            }



            nuevaTarea.NombreTarea = cmbTarea.Text;
            nuevaTarea.Fecha = dtFecha.Value;
            nuevaTarea.Lugar = cmbLugar.Text;
            nuevaTarea.Comentario = txtComentario.Text;

            nuevaTarea.AgregarTarea(nuevaTarea);
        }
    }
}
