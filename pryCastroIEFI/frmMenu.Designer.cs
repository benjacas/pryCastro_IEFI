namespace pryCastroIEFI
{
    partial class frmMenu
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            menuStrip1 = new MenuStrip();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            auditoriaToolStripMenuItem = new ToolStripMenuItem();
            timer = new System.Windows.Forms.Timer(components);
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnCerrar = new Guna.UI2.WinForms.Guna2Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { tareasToolStripMenuItem, administraciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(106, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            tareasToolStripMenuItem.Size = new Size(51, 20);
            tareasToolStripMenuItem.Text = "Tareas";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, auditoriaToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(100, 20);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(123, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // auditoriaToolStripMenuItem
            // 
            auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            auditoriaToolStripMenuItem.Size = new Size(123, 22);
            auditoriaToolStripMenuItem.Text = "Auditoria";
            auditoriaToolStripMenuItem.Click += auditoriaToolStripMenuItem_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // btnCerrar
            // 
            btnCerrar.BorderRadius = 10;
            btnCerrar.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            btnCerrar.CustomizableEdges = customizableEdges1;
            btnCerrar.DisabledState.BorderColor = Color.DarkGray;
            btnCerrar.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCerrar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCerrar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCerrar.Font = new Font("Segoe UI", 9F);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(755, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCerrar.Size = new Size(33, 27);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "X";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += frmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tareasToolStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCerrar;
    }
}