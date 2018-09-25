namespace Prueba2_NET_MarceloAranda_2018
{
    partial class buscarAutos
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
            this.cboAutos = new System.Windows.Forms.ComboBox();
            this.lblDetallesbuscar = new System.Windows.Forms.Label();
            this.lblUltimoDueñoBuscar = new System.Windows.Forms.Label();
            this.lblTelefonoBuscar = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.txtUltimoDueño = new System.Windows.Forms.TextBox();
            this.txtTelefonoUltimoDueño = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboAutos
            // 
            this.cboAutos.FormattingEnabled = true;
            this.cboAutos.Location = new System.Drawing.Point(24, 21);
            this.cboAutos.Name = "cboAutos";
            this.cboAutos.Size = new System.Drawing.Size(121, 21);
            this.cboAutos.TabIndex = 0;
            this.cboAutos.SelectedIndexChanged += new System.EventHandler(this.cboAutos_SelectedIndexChanged);
            // 
            // lblDetallesbuscar
            // 
            this.lblDetallesbuscar.AutoSize = true;
            this.lblDetallesbuscar.Location = new System.Drawing.Point(331, 29);
            this.lblDetallesbuscar.Name = "lblDetallesbuscar";
            this.lblDetallesbuscar.Size = new System.Drawing.Size(51, 13);
            this.lblDetallesbuscar.TabIndex = 1;
            this.lblDetallesbuscar.Text = "Detalles: ";
            // 
            // lblUltimoDueñoBuscar
            // 
            this.lblUltimoDueñoBuscar.AutoSize = true;
            this.lblUltimoDueñoBuscar.Location = new System.Drawing.Point(331, 65);
            this.lblUltimoDueñoBuscar.Name = "lblUltimoDueñoBuscar";
            this.lblUltimoDueñoBuscar.Size = new System.Drawing.Size(75, 13);
            this.lblUltimoDueñoBuscar.TabIndex = 2;
            this.lblUltimoDueñoBuscar.Text = "Último dueño: ";
            // 
            // lblTelefonoBuscar
            // 
            this.lblTelefonoBuscar.AutoSize = true;
            this.lblTelefonoBuscar.Location = new System.Drawing.Point(331, 101);
            this.lblTelefonoBuscar.Name = "lblTelefonoBuscar";
            this.lblTelefonoBuscar.Size = new System.Drawing.Size(115, 13);
            this.lblTelefonoBuscar.TabIndex = 3;
            this.lblTelefonoBuscar.Text = "Telefono ultimo dueño:";
            // 
            // txtDetalles
            // 
            this.txtDetalles.Location = new System.Drawing.Point(452, 29);
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(100, 20);
            this.txtDetalles.TabIndex = 4;
            // 
            // txtUltimoDueño
            // 
            this.txtUltimoDueño.Location = new System.Drawing.Point(452, 58);
            this.txtUltimoDueño.Name = "txtUltimoDueño";
            this.txtUltimoDueño.Size = new System.Drawing.Size(100, 20);
            this.txtUltimoDueño.TabIndex = 5;
            // 
            // txtTelefonoUltimoDueño
            // 
            this.txtTelefonoUltimoDueño.Location = new System.Drawing.Point(452, 101);
            this.txtTelefonoUltimoDueño.Name = "txtTelefonoUltimoDueño";
            this.txtTelefonoUltimoDueño.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoUltimoDueño.TabIndex = 6;
            // 
            // buscarAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 261);
            this.Controls.Add(this.txtTelefonoUltimoDueño);
            this.Controls.Add(this.txtUltimoDueño);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.lblTelefonoBuscar);
            this.Controls.Add(this.lblUltimoDueñoBuscar);
            this.Controls.Add(this.lblDetallesbuscar);
            this.Controls.Add(this.cboAutos);
            this.Name = "buscarAutos";
            this.Text = "BuscarAutos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAutos;
        private System.Windows.Forms.Label lblDetallesbuscar;
        private System.Windows.Forms.Label lblUltimoDueñoBuscar;
        private System.Windows.Forms.Label lblTelefonoBuscar;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.TextBox txtUltimoDueño;
        private System.Windows.Forms.TextBox txtTelefonoUltimoDueño;
    }
}