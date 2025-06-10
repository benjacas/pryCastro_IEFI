namespace pryCastroIEFI
{
    partial class frmEliminarUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvMostrar = new Guna.UI2.WinForms.Guna2DataGridView();
            btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // dgvMostrar
            // 
            dgvMostrar.AllowUserToAddRows = false;
            dgvMostrar.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvMostrar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMostrar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMostrar.ColumnHeadersHeight = 20;
            dgvMostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMostrar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMostrar.GridColor = Color.FromArgb(231, 229, 255);
            dgvMostrar.Location = new Point(65, 29);
            dgvMostrar.MultiSelect = false;
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.RowHeadersVisible = false;
            dgvMostrar.Size = new Size(694, 314);
            dgvMostrar.TabIndex = 0;
            dgvMostrar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMostrar.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMostrar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMostrar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMostrar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMostrar.ThemeStyle.BackColor = Color.White;
            dgvMostrar.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMostrar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMostrar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMostrar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvMostrar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMostrar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMostrar.ThemeStyle.HeaderStyle.Height = 20;
            dgvMostrar.ThemeStyle.ReadOnly = false;
            dgvMostrar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMostrar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMostrar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMostrar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMostrar.ThemeStyle.RowsStyle.Height = 25;
            dgvMostrar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMostrar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnEliminar
            // 
            btnEliminar.CustomizableEdges = customizableEdges1;
            btnEliminar.DisabledState.BorderColor = Color.DarkGray;
            btnEliminar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEliminar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEliminar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(65, 361);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEliminar.Size = new Size(694, 53);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEliminarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMostrar);
            Name = "frmEliminarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Eliminar Usuarios";
            Load += frmEliminarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrar;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
    }
}