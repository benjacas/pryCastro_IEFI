namespace pryCastroIEFI
{
    partial class frmAgregarTarea
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            txtTarea = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.CustomizableEdges = customizableEdges1;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(12, 52);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancelar.Size = new Size(104, 22);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.CustomizableEdges = customizableEdges3;
            btnAgregar.DisabledState.BorderColor = Color.DarkGray;
            btnAgregar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAgregar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAgregar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(122, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAgregar.Size = new Size(104, 22);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTarea
            // 
            txtTarea.CustomizableEdges = customizableEdges5;
            txtTarea.DefaultText = "";
            txtTarea.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTarea.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTarea.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTarea.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTarea.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTarea.Font = new Font("Segoe UI", 9F);
            txtTarea.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTarea.Location = new Point(12, 12);
            txtTarea.Name = "txtTarea";
            txtTarea.PlaceholderText = "";
            txtTarea.SelectedText = "";
            txtTarea.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTarea.Size = new Size(214, 34);
            txtTarea.TabIndex = 3;
            // 
            // frmAgregarTarea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(236, 86);
            ControlBox = false;
            Controls.Add(txtTarea);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Name = "frmAgregarTarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Tarea";
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2TextBox txtTarea;
    }
}