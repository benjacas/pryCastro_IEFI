namespace pryCastroIEFI
{
    partial class frmGestionUsuarios
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
            menuStrip1 = new MenuStrip();
            agregarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            eliminarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            verUsuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarUsuariosToolStripMenuItem, modificarUsuariosToolStripMenuItem, eliminarUsuariosToolStripMenuItem, verUsuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            agregarUsuariosToolStripMenuItem.Size = new Size(109, 20);
            agregarUsuariosToolStripMenuItem.Text = "Agregar Usuarios";
            agregarUsuariosToolStripMenuItem.Click += agregarUsuariosToolStripMenuItem_Click;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(118, 20);
            modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            modificarUsuariosToolStripMenuItem.Click += modificarUsuariosToolStripMenuItem_Click;
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            eliminarUsuariosToolStripMenuItem.Size = new Size(110, 20);
            eliminarUsuariosToolStripMenuItem.Text = "Eliminar Usuarios";
            eliminarUsuariosToolStripMenuItem.Click += eliminarUsuariosToolStripMenuItem_Click;
            // 
            // verUsuToolStripMenuItem
            // 
            verUsuToolStripMenuItem.Name = "verUsuToolStripMenuItem";
            verUsuToolStripMenuItem.Size = new Size(83, 20);
            verUsuToolStripMenuItem.Text = "Ver Usuarios";
            verUsuToolStripMenuItem.Click += verUsuToolStripMenuItem_Click;
            // 
            // frmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmGestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion Usuarios";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarUsuariosToolStripMenuItem;
        private ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private ToolStripMenuItem verUsuToolStripMenuItem;
    }
}