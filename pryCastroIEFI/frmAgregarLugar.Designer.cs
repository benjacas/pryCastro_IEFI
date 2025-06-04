namespace pryCastroIEFI
{
    partial class frmAgregarLugar
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
            txtLugar = new Guna.UI2.WinForms.Guna2TextBox();
            btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // txtLugar
            // 
            txtLugar.CustomizableEdges = customizableEdges1;
            txtLugar.DefaultText = "";
            txtLugar.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtLugar.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtLugar.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtLugar.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtLugar.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLugar.Font = new Font("Segoe UI", 9F);
            txtLugar.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtLugar.Location = new Point(12, 12);
            txtLugar.Name = "txtLugar";
            txtLugar.PlaceholderText = "";
            txtLugar.SelectedText = "";
            txtLugar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtLugar.Size = new Size(214, 34);
            txtLugar.TabIndex = 6;
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
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            // 
            // btnCancelar
            // 
            btnCancelar.CustomizableEdges = customizableEdges5;
            btnCancelar.DisabledState.BorderColor = Color.DarkGray;
            btnCancelar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancelar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancelar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(12, 52);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCancelar.Size = new Size(104, 22);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAgregarLugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 85);
            ControlBox = false;
            Controls.Add(txtLugar);
            Controls.Add(btnAgregar);
            Controls.Add(btnCancelar);
            Name = "frmAgregarLugar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Lugar";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtLugar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}