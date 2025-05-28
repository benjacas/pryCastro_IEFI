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
    public partial class frmAuditoria : Form
    {
        public frmAuditoria()
        {
            InitializeComponent();
        }
        clsAuditoria Auditoria = new clsAuditoria();
        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            Auditoria.MostrarGrilla(dgvMostrar);
        }
    }
}
