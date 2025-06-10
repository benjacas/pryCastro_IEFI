using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pryCastroIEFI
{
    public partial class frmRegistrarTareas : Form
    {
        public frmRegistrarTareas()
        {
            InitializeComponent();
        }

        List<clsTareas> tareasCargadas = new List<clsTareas>();
        clsTareas cargaTareaLugares = new clsTareas();
        private void cmbTarea_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void frmRegistrarTareas_Load(object sender, EventArgs e)
        {
            
            cargaTareaLugares.CargarNombresDeTarea(cmbTarea);
            cargaTareaLugares.CargarNombresDeLugares(cmbLugar);
            
            string[] vecColumnas = new string[] { "Tarea", "Lugar", "Fecha" };


            foreach (string columnas in vecColumnas)
            {
                dgvMostrar.Columns.Add("col", columnas);
            }

            dtFecha.MaxDate = DateTime.Now;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            string tarea = cmbTarea.Text;
            DateTime fecha = dtFecha.Value;
            string lugar = cmbLugar.Text;

            if (!string.IsNullOrEmpty(tarea) && !string.IsNullOrEmpty(lugar))
            {
                dgvMostrar.Rows.Add(tarea, lugar, fecha);
                

                clsTareas nueva = new clsTareas { NombreTarea = tarea, Lugar = lugar, Fecha = fecha };
                tareasCargadas.Add(nueva);


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
            string uniforme="";
            string licencia="";
            string reclamo="";
            string comentario=txtComentario.Text;

            if (chkInsumo.Checked)
            {
                uniforme = "Insumo";
            }
            if (chkEstudio.Checked)
            {
                licencia = "Estudio";
            }
            if (chkRecibo.Checked)
            {
                reclamo = "Recibo";
            }
            if (chkVacacion.Checked)
            {
                licencia = "Vacación";
            }
            if (chkSalario.Checked)
            {
                reclamo = "salario";
            }
            if (chkVacacion.Checked && chkEstudio.Checked)
            {
                licencia = "Estudio, Vacación";
            }
            if (chkSalario.Checked && chkRecibo.Checked) 
            {
                reclamo = "Salario, Recbio";
            }

            nuevaTarea.GuardarDetallesYAsignar(uniforme,licencia,reclamo,comentario);
        }



        private void btnGuardarTareas_Click(object sender, EventArgs e)
        {
            clsTareas nuevaTarea = new clsTareas();

            nuevaTarea.AgregarTarea(tareasCargadas);
            tareasCargadas.Clear();
        }
    }
}
