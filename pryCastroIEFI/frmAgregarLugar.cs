﻿using System;
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
    public partial class frmAgregarLugar : Form
    {
        public frmAgregarLugar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsTareas nombreLugar = new clsTareas();
            string nuevoNombre = txtLugar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevoNombre))
            {
                MessageBox.Show("Debe ingresar un nombre válido.");
                return;
            }

            nombreLugar.NombreParaAgregarLugares(nuevoNombre);
            txtLugar.Clear();

            this.Close();
        }
    }
}
