namespace Prueba2_NET_MarceloAranda_2018
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsRegistrarAutomóvilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opRegistrarAutomóvilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.opBuscarAutomóvilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsRegistrarAutomóvilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnsAutomovil";
            // 
            // mnsRegistrarAutomóvilToolStripMenuItem
            // 
            this.mnsRegistrarAutomóvilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opRegistrarAutomóvilToolStripMenuItem1,
            this.opBuscarAutomóvilToolStripMenuItem});
            this.mnsRegistrarAutomóvilToolStripMenuItem.Name = "mnsRegistrarAutomóvilToolStripMenuItem";
            this.mnsRegistrarAutomóvilToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.mnsRegistrarAutomóvilToolStripMenuItem.Text = "Inicio";
            // 
            // opRegistrarAutomóvilToolStripMenuItem1
            // 
            this.opRegistrarAutomóvilToolStripMenuItem1.Name = "opRegistrarAutomóvilToolStripMenuItem1";
            this.opRegistrarAutomóvilToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.opRegistrarAutomóvilToolStripMenuItem1.Text = "Registrar automóvil";
            this.opRegistrarAutomóvilToolStripMenuItem1.Click += new System.EventHandler(this.opRegistrarAutomóvilToolStripMenuItem1_Click);
            // 
            // opBuscarAutomóvilToolStripMenuItem
            // 
            this.opBuscarAutomóvilToolStripMenuItem.Name = "opBuscarAutomóvilToolStripMenuItem";
            this.opBuscarAutomóvilToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.opBuscarAutomóvilToolStripMenuItem.Text = "Buscar Automóvil";
            this.opBuscarAutomóvilToolStripMenuItem.Click += new System.EventHandler(this.opBuscarAutomóvilToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsRegistrarAutomóvilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opRegistrarAutomóvilToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opBuscarAutomóvilToolStripMenuItem;
    }
}

