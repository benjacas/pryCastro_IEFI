namespace pryCastroIEFI
{
    partial class frmMostrarUsuarios
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvMostrar = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBuscarNombre = new Guna.UI2.WinForms.Guna2TextBox();
            lblNombreBuscar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).BeginInit();
            SuspendLayout();
            // 
            // dgvMostrar
            // 
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
            dgvMostrar.Location = new Point(53, 39);
            dgvMostrar.MultiSelect = false;
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.ReadOnly = true;
            dgvMostrar.RowHeadersVisible = false;
            dgvMostrar.Size = new Size(679, 267);
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
            dgvMostrar.ThemeStyle.ReadOnly = true;
            dgvMostrar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMostrar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMostrar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMostrar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMostrar.ThemeStyle.RowsStyle.Height = 25;
            dgvMostrar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMostrar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.CustomizableEdges = customizableEdges1;
            txtBuscarNombre.DefaultText = "";
            txtBuscarNombre.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBuscarNombre.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBuscarNombre.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarNombre.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBuscarNombre.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarNombre.Font = new Font("Segoe UI", 9F);
            txtBuscarNombre.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBuscarNombre.Location = new Point(53, 343);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.PlaceholderText = "";
            txtBuscarNombre.SelectedText = "";
            txtBuscarNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscarNombre.Size = new Size(200, 36);
            txtBuscarNombre.TabIndex = 1;
            // 
            // lblNombreBuscar
            // 
            lblNombreBuscar.BackColor = Color.Transparent;
            lblNombreBuscar.Location = new Point(53, 320);
            lblNombreBuscar.Name = "lblNombreBuscar";
            lblNombreBuscar.Size = new Size(106, 17);
            lblNombreBuscar.TabIndex = 2;
            lblNombreBuscar.Text = "Buscar por Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.CustomizableEdges = customizableEdges3;
            btnBuscar.DisabledState.BorderColor = Color.DarkGray;
            btnBuscar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscar.Font = new Font("Segoe UI", 9F);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(272, 343);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBuscar.Size = new Size(180, 36);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // frmMostrarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 420);
            Controls.Add(btnBuscar);
            Controls.Add(lblNombreBuscar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(dgvMostrar);
            Name = "frmMostrarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar Usuarios";
            Load += frmMostrarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreBuscar;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
    }
}