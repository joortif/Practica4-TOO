﻿namespace Practica4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            this.cmsMenuContextualPadre = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tscdAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tscdNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCerrarDocs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditorPadre = new System.Windows.Forms.ToolStrip();
            this.bhbtNuevo = new System.Windows.Forms.ToolStripButton();
            this.bhbtAbrir = new System.Windows.Forms.ToolStripButton();
            this.msMenu.SuspendLayout();
            this.ssBarraEstado.SuspendLayout();
            this.cmsMenuContextualPadre.SuspendLayout();
            this.tsEditorPadre.SuspendLayout();
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
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(1067, 28);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenu";
            // 
            // smArchivo
            // 
            this.smArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smNuevo,
            this.abrirToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem,
            this.smSalir});
            this.smArchivo.Name = "smArchivo";
            this.smArchivo.Size = new System.Drawing.Size(73, 24);
            this.smArchivo.Text = "Archivo";
            // 
            // smNuevo
            // 
            this.smNuevo.Name = "smNuevo";
            this.smNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.smNuevo.Size = new System.Drawing.Size(188, 26);
            this.smNuevo.Text = "Nuevo";
            this.smNuevo.Click += new System.EventHandler(this.smNuevo_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar todo";
            this.cerrarTodoToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodoToolStripMenuItem_Click);
            // 
            // smSalir
            // 
            this.smSalir.Name = "smSalir";
            this.smSalir.Size = new System.Drawing.Size(188, 26);
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
            // 
            // smArrangItems
            // 
            this.smArrangItems.Name = "smArrangItems";
            this.smArrangItems.Size = new System.Drawing.Size(179, 26);
            this.smArrangItems.Text = "ArrangeIcons";
            this.smArrangItems.Click += new System.EventHandler(this.smArrangItems_Click);
            // 
            // smCascada
            // 
            this.smCascada.Name = "smCascada";
            this.smCascada.Size = new System.Drawing.Size(179, 26);
            this.smCascada.Text = "Cascada";
            this.smCascada.Click += new System.EventHandler(this.smCascada_Click);
            // 
            // smHorizontal
            // 
            this.smHorizontal.Name = "smHorizontal";
            this.smHorizontal.Size = new System.Drawing.Size(179, 26);
            this.smHorizontal.Text = "Horizontal";
            this.smHorizontal.Click += new System.EventHandler(this.smHorizontal_Click);
            // 
            // smVertical
            // 
            this.smVertical.Name = "smVertical";
            this.smVertical.Size = new System.Drawing.Size(179, 26);
            this.smVertical.Text = "Vertical";
            this.smVertical.Click += new System.EventHandler(this.smVertical_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBarraEstado});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // tsmiBarraEstado
            // 
            this.tsmiBarraEstado.Checked = true;
            this.tsmiBarraEstado.CheckOnClick = true;
            this.tsmiBarraEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiBarraEstado.Name = "tsmiBarraEstado";
            this.tsmiBarraEstado.Size = new System.Drawing.Size(197, 26);
            this.tsmiBarraEstado.Text = "Barra de estado";
            this.tsmiBarraEstado.Click += new System.EventHandler(this.tsmiBarraEstado_Click);
            // 
            // ssBarraEstado
            // 
            this.ssBarraEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSeleccionado,
            this.tslDocumento});
            this.ssBarraEstado.Location = new System.Drawing.Point(0, 532);
            this.ssBarraEstado.Name = "ssBarraEstado";
            this.ssBarraEstado.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssBarraEstado.Size = new System.Drawing.Size(1067, 22);
            this.ssBarraEstado.TabIndex = 1;
            this.ssBarraEstado.Text = "statusStrip1";
            // 
            // tslSeleccionado
            // 
            this.tslSeleccionado.Name = "tslSeleccionado";
            this.tslSeleccionado.Size = new System.Drawing.Size(0, 16);
            // 
            // tslDocumento
            // 
            this.tslDocumento.Name = "tslDocumento";
            this.tslDocumento.Size = new System.Drawing.Size(1047, 16);
            this.tslDocumento.Spring = true;
            // 
            // cmsMenuContextualPadre
            // 
            this.cmsMenuContextualPadre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuContextualPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscdAbrir,
            this.tscdNuevo,
            this.toolStripSeparator1,
            this.tsmiCerrarDocs});
            this.cmsMenuContextualPadre.Name = "cmsMenuContextualPadre";
            this.cmsMenuContextualPadre.Size = new System.Drawing.Size(205, 82);
            // 
            // tscdAbrir
            // 
            this.tscdAbrir.Name = "tscdAbrir";
            this.tscdAbrir.Size = new System.Drawing.Size(210, 24);
            this.tscdAbrir.Text = "Abrir";
            this.tscdAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // tscdNuevo
            // 
            this.tscdNuevo.Name = "tscdNuevo";
            this.tscdNuevo.Size = new System.Drawing.Size(210, 24);
            this.tscdNuevo.Text = "Nuevo";
            this.tscdNuevo.Click += new System.EventHandler(this.smNuevo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // tsmiCerrarDocs
            // 
            this.tsmiCerrarDocs.Name = "tsmiCerrarDocs";
            this.tsmiCerrarDocs.Size = new System.Drawing.Size(210, 24);
            this.tsmiCerrarDocs.Text = "Cerrar documentos";
            this.tsmiCerrarDocs.Click += new System.EventHandler(this.tsmiCerrarDocs_Click);
            // 
            // tsEditorPadre
            // 
            this.tsEditorPadre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEditorPadre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bhbtNuevo,
            this.bhbtAbrir});
            this.tsEditorPadre.Location = new System.Drawing.Point(0, 28);
            this.tsEditorPadre.Name = "tsEditorPadre";
            this.tsEditorPadre.Size = new System.Drawing.Size(1067, 27);
            this.tsEditorPadre.TabIndex = 2;
            this.tsEditorPadre.Text = "toolStrip1";
            // 
            // bhbtNuevo
            // 
            this.bhbtNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtNuevo.Image = ((System.Drawing.Image)(resources.GetObject("bhbtNuevo.Image")));
            this.bhbtNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtNuevo.MergeIndex = 1;
            this.bhbtNuevo.Name = "bhbtNuevo";
            this.bhbtNuevo.Size = new System.Drawing.Size(29, 24);
            this.bhbtNuevo.Text = "Nuevo";
            this.bhbtNuevo.Click += new System.EventHandler(this.smNuevo_Click);
            // 
            // bhbtAbrir
            // 
            this.bhbtAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtAbrir.Image = ((System.Drawing.Image)(resources.GetObject("bhbtAbrir.Image")));
            this.bhbtAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtAbrir.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.bhbtAbrir.MergeIndex = 2;
            this.bhbtAbrir.Name = "bhbtAbrir";
            this.bhbtAbrir.Size = new System.Drawing.Size(29, 24);
            this.bhbtAbrir.Text = "Abrir";
            this.bhbtAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.cmsMenuContextualPadre;
            this.Controls.Add(this.tsEditorPadre);
            this.Controls.Add(this.ssBarraEstado);
            this.Controls.Add(this.msMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrincipal";
            this.Text = "Editor de texto";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.MdiChildActivate += new System.EventHandler(this.FormPrincipal_MdiChildActivate);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.FormPrincipal_Layout);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ssBarraEstado.ResumeLayout(false);
            this.ssBarraEstado.PerformLayout();
            this.cmsMenuContextualPadre.ResumeLayout(false);
            this.tsEditorPadre.ResumeLayout(false);
            this.tsEditorPadre.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip cmsMenuContextualPadre;
        private System.Windows.Forms.ToolStripMenuItem tscdAbrir;
        private System.Windows.Forms.ToolStripMenuItem tscdNuevo;
        private System.Windows.Forms.ToolStrip tsEditorPadre;
        private System.Windows.Forms.ToolStripButton bhbtNuevo;
        private System.Windows.Forms.ToolStripButton bhbtAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarDocs;
    }
}

