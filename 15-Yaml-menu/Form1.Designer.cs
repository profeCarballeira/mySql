namespace _15_Yaml_menu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archioToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            cargarConexiónToolStripMenuItem = new ToolStripMenuItem();
            tresToolStripMenuItem = new ToolStripMenuItem();
            dosToolStripMenuItem = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archioToolStripMenuItem, editarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archioToolStripMenuItem
            // 
            archioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cargarConexiónToolStripMenuItem, dosToolStripMenuItem, tresToolStripMenuItem });
            archioToolStripMenuItem.Name = "archioToolStripMenuItem";
            archioToolStripMenuItem.Size = new Size(54, 20);
            archioToolStripMenuItem.Text = "Archio";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(49, 20);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // cargarConexiónToolStripMenuItem
            // 
            cargarConexiónToolStripMenuItem.Name = "cargarConexiónToolStripMenuItem";
            cargarConexiónToolStripMenuItem.Size = new Size(180, 22);
            cargarConexiónToolStripMenuItem.Text = "Cargar conexión";
            cargarConexiónToolStripMenuItem.Click += cargarConexiónToolStripMenuItem_Click;
            // 
            // tresToolStripMenuItem
            // 
            tresToolStripMenuItem.Name = "tresToolStripMenuItem";
            tresToolStripMenuItem.Size = new Size(180, 22);
            tresToolStripMenuItem.Text = "tres";
            // 
            // dosToolStripMenuItem
            // 
            dosToolStripMenuItem.Name = "dosToolStripMenuItem";
            dosToolStripMenuItem.Size = new Size(177, 6);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archioToolStripMenuItem;
        private ToolStripMenuItem cargarConexiónToolStripMenuItem;
        private ToolStripSeparator dosToolStripMenuItem;
        private ToolStripMenuItem tresToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
