namespace pryCastroIEFI
{
    partial class frmMostrarTareas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarTareas));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvMostrar = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBuscarNombre = new Guna.UI2.WinForms.Guna2TextBox();
            btnBuscarNombre = new Guna.UI2.WinForms.Guna2Button();
            lblBuscarNombre = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnVolver = new Guna.UI2.WinForms.Guna2ImageButton();
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
            dgvMostrar.Location = new Point(60, 30);
            dgvMostrar.MultiSelect = false;
            dgvMostrar.Name = "dgvMostrar";
            dgvMostrar.ReadOnly = true;
            dgvMostrar.RowHeadersVisible = false;
            dgvMostrar.Size = new Size(689, 330);
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
            txtBuscarNombre.Location = new Point(59, 402);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.PlaceholderText = "Buscar por Nombre";
            txtBuscarNombre.SelectedText = "";
            txtBuscarNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtBuscarNombre.Size = new Size(200, 36);
            txtBuscarNombre.TabIndex = 2;
            // 
            // btnBuscarNombre
            // 
            btnBuscarNombre.CustomizableEdges = customizableEdges3;
            btnBuscarNombre.DisabledState.BorderColor = Color.DarkGray;
            btnBuscarNombre.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBuscarNombre.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBuscarNombre.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBuscarNombre.Font = new Font("Segoe UI", 9F);
            btnBuscarNombre.ForeColor = Color.White;
            btnBuscarNombre.Location = new Point(265, 408);
            btnBuscarNombre.Name = "btnBuscarNombre";
            btnBuscarNombre.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBuscarNombre.Size = new Size(180, 30);
            btnBuscarNombre.TabIndex = 3;
            btnBuscarNombre.Text = "Buscar";
            btnBuscarNombre.Click += btnBuscarNombre_Click;
            // 
            // lblBuscarNombre
            // 
            lblBuscarNombre.BackColor = Color.Transparent;
            lblBuscarNombre.Location = new Point(60, 379);
            lblBuscarNombre.Name = "lblBuscarNombre";
            lblBuscarNombre.Size = new Size(106, 17);
            lblBuscarNombre.TabIndex = 4;
            lblBuscarNombre.Text = "Buscar por Nombre";
            // 
            // btnVolver
            // 
            btnVolver.CheckedState.ImageSize = new Size(64, 64);
            btnVolver.HoverState.ImageSize = new Size(64, 64);
            btnVolver.Image = (Image)resources.GetObject("btnVolver.Image");
            btnVolver.ImageOffset = new Point(0, 0);
            btnVolver.ImageRotate = 0F;
            btnVolver.Location = new Point(2, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.PressedState.ImageSize = new Size(64, 64);
            btnVolver.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnVolver.Size = new Size(35, 36);
            btnVolver.TabIndex = 10;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmMostrarTareas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblBuscarNombre);
            Controls.Add(btnBuscarNombre);
            Controls.Add(txtBuscarNombre);
            Controls.Add(dgvMostrar);
            Name = "frmMostrarTareas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar Tareas";
            Load += frmMostrarTareas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMostrar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvMostrar;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarNombre;
        private Guna.UI2.WinForms.Guna2Button btnBuscarNombre;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBuscarNombre;
        private Guna.UI2.WinForms.Guna2ImageButton btnVolver;
    }
}