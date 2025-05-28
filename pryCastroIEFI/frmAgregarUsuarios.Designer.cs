namespace pryCastroIEFI
{
    partial class frmAgregarUsuarios
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvMostrar = new Guna.UI2.WinForms.Guna2DataGridView();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            txtContraseña = new Guna.UI2.WinForms.Guna2TextBox();
            lblNombreUsuario = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblContraseña = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblRol = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cmbRol = new Guna.UI2.WinForms.Guna2ComboBox();
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
            dgvMostrar.ColumnHeadersHeight = 4;
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
            dgvMostrar.Location = new Point(53, 25);
            dgvMostrar.MultiSelect = false;
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.ReadOnly = true;
            dgvMostrar.RowHeadersVisible = false;
            dgvMostrar.Size = new Size(709, 288);
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
            dgvMostrar.ThemeStyle.HeaderStyle.Height = 4;
            dgvMostrar.ThemeStyle.ReadOnly = true;
            dgvMostrar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMostrar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMostrar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvMostrar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMostrar.ThemeStyle.RowsStyle.Height = 25;
            dgvMostrar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMostrar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnAgregar
            // 
            btnAgregar.CustomizableEdges = customizableEdges1;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(53, 400);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAgregar.Size = new Size(709, 38);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CustomizableEdges = customizableEdges3;
            txtNombreUsuario.DefaultText = "";
            txtNombreUsuario.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNombreUsuario.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNombreUsuario.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNombreUsuario.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.Font = new Font("Segoe UI", 9F);
            txtNombreUsuario.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNombreUsuario.Location = new Point(53, 358);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.PlaceholderText = "";
            txtNombreUsuario.SelectedText = "";
            txtNombreUsuario.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtNombreUsuario.Size = new Size(200, 36);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.CustomizableEdges = customizableEdges5;
            txtContraseña.DefaultText = "";
            txtContraseña.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtContraseña.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtContraseña.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtContraseña.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Font = new Font("Segoe UI", 9F);
            txtContraseña.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtContraseña.Location = new Point(279, 358);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "";
            txtContraseña.SelectedText = "";
            txtContraseña.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtContraseña.Size = new Size(206, 36);
            txtContraseña.TabIndex = 3;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.BackColor = Color.Transparent;
            lblNombreUsuario.Location = new Point(53, 335);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(109, 17);
            lblNombreUsuario.TabIndex = 5;
            lblNombreUsuario.Text = "Nombre del Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Location = new Point(279, 335);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(63, 17);
            lblContraseña.TabIndex = 6;
            lblContraseña.Text = "Contraseña";
            // 
            // lblRol
            // 
            lblRol.BackColor = Color.Transparent;
            lblRol.Location = new Point(509, 335);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(85, 17);
            lblRol.TabIndex = 7;
            lblRol.Text = "Tipo de Usuario";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.Transparent;
            cmbRol.CustomizableEdges = customizableEdges7;
            cmbRol.DrawMode = DrawMode.OwnerDrawFixed;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FocusedColor = Color.FromArgb(94, 148, 255);
            cmbRol.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cmbRol.Font = new Font("Segoe UI", 10F);
            cmbRol.ForeColor = Color.FromArgb(68, 88, 112);
            cmbRol.ItemHeight = 30;
            cmbRol.Location = new Point(509, 358);
            cmbRol.Name = "cmbRol";
            cmbRol.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cmbRol.Size = new Size(253, 36);
            cmbRol.TabIndex = 8;
            // 
            // frmAgregarUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(lblContraseña);
            Controls.Add(lblNombreUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMostrar);
            Name = "frmAgregarUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Usuarios";
            Load += frmAgregarUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNombreUsuario;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblContraseña;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRol;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRol;
    }
}