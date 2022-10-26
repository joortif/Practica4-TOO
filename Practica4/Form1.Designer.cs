namespace Practica4
{
    partial class FormPrincipal
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.smArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.smNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.smSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.smVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.smArrangItems = new System.Windows.Forms.ToolStripMenuItem();
            this.smCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.smHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.smVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smArchivo,
            this.smVentana});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1067, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // smArchivo
            // 
            this.smArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smNuevo,
            this.smSalir});
            this.smArchivo.Name = "smArchivo";
            this.smArchivo.Size = new System.Drawing.Size(73, 24);
            this.smArchivo.Text = "Archivo";
            // 
            // smNuevo
            // 
            this.smNuevo.Name = "smNuevo";
            this.smNuevo.Size = new System.Drawing.Size(135, 26);
            this.smNuevo.Text = "Nuevo";
            this.smNuevo.Click += new System.EventHandler(this.smNuevo_Click);
            // 
            // smSalir
            // 
            this.smSalir.Name = "smSalir";
            this.smSalir.Size = new System.Drawing.Size(135, 26);
            this.smSalir.Text = "Salir";
            this.smSalir.Click += new System.EventHandler(this.smSalir_Click);
            // 
            // smVentana
            // 
            this.smVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smArrangItems,
            this.smCascada,
            this.smHorizontal,
            this.smVertical});
            this.smVentana.Name = "smVentana";
            this.smVentana.Size = new System.Drawing.Size(76, 24);
            this.smVentana.Text = "Ventana";
            this.smVentana.DropDownOpening += new System.EventHandler(this.smVentana_DropDownOpening);
            // 
            // smArrangItems
            // 
            this.smArrangItems.Name = "smArrangItems";
            this.smArrangItems.Size = new System.Drawing.Size(224, 26);
            this.smArrangItems.Text = "ArrangeIcons";
            this.smArrangItems.Click += new System.EventHandler(this.smArrangItems_Click);
            // 
            // smCascada
            // 
            this.smCascada.Name = "smCascada";
            this.smCascada.Size = new System.Drawing.Size(224, 26);
            this.smCascada.Text = "Cascada";
            this.smCascada.Click += new System.EventHandler(this.smCascada_Click);
            // 
            // smHorizontal
            // 
            this.smHorizontal.Name = "smHorizontal";
            this.smHorizontal.Size = new System.Drawing.Size(224, 26);
            this.smHorizontal.Text = "Horizontal";
            this.smHorizontal.Click += new System.EventHandler(this.smHorizontal_Click);
            // 
            // smVertical
            // 
            this.smVertical.Name = "smVertical";
            this.smVertical.Size = new System.Drawing.Size(224, 26);
            this.smVertical.Text = "Vertical";
            this.smVertical.Click += new System.EventHandler(this.smVertical_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipal";
            this.Text = "Editor de texto";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem smArchivo;
        private System.Windows.Forms.ToolStripMenuItem smNuevo;
        private System.Windows.Forms.ToolStripMenuItem smSalir;
        private System.Windows.Forms.ToolStripMenuItem smVentana;
        private System.Windows.Forms.ToolStripMenuItem smArrangItems;
        private System.Windows.Forms.ToolStripMenuItem smCascada;
        private System.Windows.Forms.ToolStripMenuItem smHorizontal;
        private System.Windows.Forms.ToolStripMenuItem smVertical;
    }
}

