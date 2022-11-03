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
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.smVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.smArrangItems = new System.Windows.Forms.ToolStripMenuItem();
            this.smCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.smHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.smVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBarraEstado = new System.Windows.Forms.ToolStripMenuItem();
            this.ssBarraEstado = new System.Windows.Forms.StatusStrip();
            this.tslSeleccionado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDocumento = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu.SuspendLayout();
            this.ssBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smArchivo,
            this.smVentana,
            this.verToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.MdiWindowListItem = this.smVentana;
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(800, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // smArchivo
            // 
            this.smArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smNuevo,
            this.abrirToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem,
            this.smSalir});
            this.smArchivo.Name = "smArchivo";
            this.smArchivo.Size = new System.Drawing.Size(60, 20);
            this.smArchivo.Text = "Archivo";
            // 
            // smNuevo
            // 
            this.smNuevo.Name = "smNuevo";
            this.smNuevo.Size = new System.Drawing.Size(180, 22);
            this.smNuevo.Text = "Nuevo";
            this.smNuevo.Click += new System.EventHandler(this.smNuevo_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar todo";
            // 
            // smSalir
            // 
            this.smSalir.Name = "smSalir";
            this.smSalir.Size = new System.Drawing.Size(180, 22);
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
            this.smVentana.Size = new System.Drawing.Size(61, 20);
            this.smVentana.Text = "Ventana";
            // 
            // smArrangItems
            // 
            this.smArrangItems.Name = "smArrangItems";
            this.smArrangItems.Size = new System.Drawing.Size(144, 22);
            this.smArrangItems.Text = "ArrangeIcons";
            this.smArrangItems.Click += new System.EventHandler(this.smArrangItems_Click);
            // 
            // smCascada
            // 
            this.smCascada.Name = "smCascada";
            this.smCascada.Size = new System.Drawing.Size(144, 22);
            this.smCascada.Text = "Cascada";
            this.smCascada.Click += new System.EventHandler(this.smCascada_Click);
            // 
            // smHorizontal
            // 
            this.smHorizontal.Name = "smHorizontal";
            this.smHorizontal.Size = new System.Drawing.Size(144, 22);
            this.smHorizontal.Text = "Horizontal";
            this.smHorizontal.Click += new System.EventHandler(this.smHorizontal_Click);
            // 
            // smVertical
            // 
            this.smVertical.Name = "smVertical";
            this.smVertical.Size = new System.Drawing.Size(144, 22);
            this.smVertical.Text = "Vertical";
            this.smVertical.Click += new System.EventHandler(this.smVertical_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBarraEstado});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // tsmiBarraEstado
            // 
            this.tsmiBarraEstado.Checked = true;
            this.tsmiBarraEstado.CheckOnClick = true;
            this.tsmiBarraEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiBarraEstado.Name = "tsmiBarraEstado";
            this.tsmiBarraEstado.Size = new System.Drawing.Size(155, 22);
            this.tsmiBarraEstado.Text = "Barra de estado";
            this.tsmiBarraEstado.Click += new System.EventHandler(this.tsmiBarraEstado_Click);
            // 
            // ssBarraEstado
            // 
            this.ssBarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSeleccionado,
            this.tslDocumento});
            this.ssBarraEstado.Location = new System.Drawing.Point(0, 428);
            this.ssBarraEstado.Name = "ssBarraEstado";
            this.ssBarraEstado.Size = new System.Drawing.Size(800, 22);
            this.ssBarraEstado.TabIndex = 1;
            this.ssBarraEstado.Text = "statusStrip1";
            // 
            // tslSeleccionado
            // 
            this.tslSeleccionado.Name = "tslSeleccionado";
            this.tslSeleccionado.Size = new System.Drawing.Size(0, 17);
            // 
            // tslDocumento
            // 
            this.tslDocumento.Name = "tslDocumento";
            this.tslDocumento.Size = new System.Drawing.Size(785, 17);
            this.tslDocumento.Spring = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ssBarraEstado);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "FormPrincipal";
            this.Text = "Editor de texto";
            this.MdiChildActivate += new System.EventHandler(this.FormPrincipal_MdiChildActivate);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssBarraEstado.ResumeLayout(false);
            this.ssBarraEstado.PerformLayout();
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
        private System.Windows.Forms.StatusStrip ssBarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel tslSeleccionado;
        private System.Windows.Forms.ToolStripStatusLabel tslDocumento;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBarraEstado;
    }
}

