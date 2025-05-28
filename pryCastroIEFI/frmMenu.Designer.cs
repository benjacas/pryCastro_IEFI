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
            menuStrip1 = new MenuStrip();
            tareasToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            gestionDeUsuariosToolStripMenuItem = new ToolStripMenuItem();
            auditoriaToolStripMenuItem = new ToolStripMenuItem();
            miPerfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tareasToolStripMenuItem, administraciónToolStripMenuItem, miPerfilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
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
            administraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionDeUsuariosToolStripMenuItem, auditoriaToolStripMenuItem });
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(100, 20);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // gestionDeUsuariosToolStripMenuItem
            // 
            gestionDeUsuariosToolStripMenuItem.Name = "gestionDeUsuariosToolStripMenuItem";
            gestionDeUsuariosToolStripMenuItem.Size = new Size(178, 22);
            gestionDeUsuariosToolStripMenuItem.Text = "Gestion de Usuarios";
            gestionDeUsuariosToolStripMenuItem.Click += gestionDeUsuariosToolStripMenuItem_Click;
            // 
            // auditoriaToolStripMenuItem
            // 
            auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            auditoriaToolStripMenuItem.Size = new Size(178, 22);
            auditoriaToolStripMenuItem.Text = "Auditoria";
            auditoriaToolStripMenuItem.Click += auditoriaToolStripMenuItem_Click;
            // 
            // miPerfilToolStripMenuItem
            // 
            miPerfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesionToolStripMenuItem, cambiarContraseñaToolStripMenuItem });
            miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            miPerfilToolStripMenuItem.Size = new Size(63, 20);
            miPerfilToolStripMenuItem.Text = "Mi Perfil";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(182, 22);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(182, 22);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
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
        private ToolStripMenuItem gestionDeUsuariosToolStripMenuItem;
        private ToolStripMenuItem auditoriaToolStripMenuItem;
        private ToolStripMenuItem miPerfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}