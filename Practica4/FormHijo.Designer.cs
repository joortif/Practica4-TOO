namespace Practica4
{
    partial class FormHijo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHijo));
            this.rtbTexto = new System.Windows.Forms.RichTextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.msMenuHijo = new System.Windows.Forms.MenuStrip();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenuContextualHijo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tscdDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscdCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tscdCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tscdPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.tscdCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditorHijo = new System.Windows.Forms.ToolStrip();
            this.bhbtGuardar = new System.Windows.Forms.ToolStripButton();
            this.bhbtGuardarComo = new System.Windows.Forms.ToolStripButton();
            this.tsSeparador = new System.Windows.Forms.ToolStripSeparator();
            this.bhbtDeshacer = new System.Windows.Forms.ToolStripButton();
            this.bhbtRehacer = new System.Windows.Forms.ToolStripButton();
            this.bhbtCortar = new System.Windows.Forms.ToolStripButton();
            this.bhbtCopiar = new System.Windows.Forms.ToolStripButton();
            this.bhbtPegar = new System.Windows.Forms.ToolStripButton();
            this.tsmiRehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeleccionarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbtSeleccionarTodo = new System.Windows.Forms.ToolStripButton();
            this.msMenuHijo.SuspendLayout();
            this.cmsMenuContextualHijo.SuspendLayout();
            this.tsEditorHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(0, 0);
            this.rtbTexto.Margin = new System.Windows.Forms.Padding(4);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(1067, 554);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            this.rtbTexto.TextChanged += new System.EventHandler(this.rtbTexto_TextChanged);
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCerrar.Location = new System.Drawing.Point(453, 503);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(95, 36);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // msMenuHijo
            // 
            this.msMenuHijo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiEdicion,
            this.fuenteToolStripMenuItem});
            this.msMenuHijo.Location = new System.Drawing.Point(0, 0);
            this.msMenuHijo.Name = "msMenuHijo";
            this.msMenuHijo.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenuHijo.Size = new System.Drawing.Size(1067, 28);
            this.msMenuHijo.TabIndex = 2;
            this.msMenuHijo.Text = "menuStrip1";
            this.msMenuHijo.Visible = false;
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGuardar,
            this.tsmiGuardarComo,
            this.toolStripSeparator1,
            this.tsmiCerrar});
            this.tsmiArchivo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(73, 24);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiGuardar
            // 
            this.tsmiGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiGuardar.MergeIndex = 2;
            this.tsmiGuardar.Name = "tsmiGuardar";
            this.tsmiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiGuardar.Size = new System.Drawing.Size(239, 26);
            this.tsmiGuardar.Text = "Guardar";
            this.tsmiGuardar.Click += new System.EventHandler(this.tsmiGuardar_Click);
            // 
            // tsmiGuardarComo
            // 
            this.tsmiGuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiGuardarComo.MergeIndex = 3;
            this.tsmiGuardarComo.Name = "tsmiGuardarComo";
            this.tsmiGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.tsmiGuardarComo.Size = new System.Drawing.Size(239, 26);
            this.tsmiGuardarComo.Text = "Guardar como";
            this.tsmiGuardarComo.Click += new System.EventHandler(this.tsmiGuardarComo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 4;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // tsmiCerrar
            // 
            this.tsmiCerrar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiCerrar.MergeIndex = 5;
            this.tsmiCerrar.Name = "tsmiCerrar";
            this.tsmiCerrar.Size = new System.Drawing.Size(239, 26);
            this.tsmiCerrar.Text = "Cerrar";
            this.tsmiCerrar.Click += new System.EventHandler(this.tsmiCerrar_Click);
            // 
            // tsmiEdicion
            // 
            this.tsmiEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeshacer,
            this.tsmiRehacer,
            this.toolStripSeparator2,
            this.tsmiCortar,
            this.tsmiCopiar,
            this.tsmiPegar,
            this.tsmiSeleccionarTodo});
            this.tsmiEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiEdicion.MergeIndex = 1;
            this.tsmiEdicion.Name = "tsmiEdicion";
            this.tsmiEdicion.Size = new System.Drawing.Size(72, 24);
            this.tsmiEdicion.Text = "Edición";
            // 
            // tsmiDeshacer
            // 
            this.tsmiDeshacer.Name = "tsmiDeshacer";
            this.tsmiDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiDeshacer.Size = new System.Drawing.Size(254, 26);
            this.tsmiDeshacer.Text = "Deshacer";
            this.tsmiDeshacer.Click += new System.EventHandler(this.tsmiDeshacer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // tsmiCortar
            // 
            this.tsmiCortar.Name = "tsmiCortar";
            this.tsmiCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCortar.Size = new System.Drawing.Size(254, 26);
            this.tsmiCortar.Text = "Cortar";
            this.tsmiCortar.Click += new System.EventHandler(this.tsmiCortar_Click);
            // 
            // tsmiCopiar
            // 
            this.tsmiCopiar.Name = "tsmiCopiar";
            this.tsmiCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopiar.Size = new System.Drawing.Size(254, 26);
            this.tsmiCopiar.Text = "Copiar";
            this.tsmiCopiar.Click += new System.EventHandler(this.tsmiCopiar_Click);
            // 
            // tsmiPegar
            // 
            this.tsmiPegar.Name = "tsmiPegar";
            this.tsmiPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPegar.Size = new System.Drawing.Size(254, 26);
            this.tsmiPegar.Text = "Pegar";
            this.tsmiPegar.Click += new System.EventHandler(this.tsmiPegar_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // cmsMenuContextualHijo
            // 
            this.cmsMenuContextualHijo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenuContextualHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscdDeshacer,
            this.toolStripSeparator3,
            this.tscdCortar,
            this.tscdCopiar,
            this.tscdPegar,
            this.tscdCerrar});
            this.cmsMenuContextualHijo.Name = "cmsMenuContextualHijo";
            this.cmsMenuContextualHijo.Size = new System.Drawing.Size(140, 130);
            // 
            // tscdDeshacer
            // 
            this.tscdDeshacer.Name = "tscdDeshacer";
            this.tscdDeshacer.Size = new System.Drawing.Size(139, 24);
            this.tscdDeshacer.Text = "Deshacer";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(136, 6);
            // 
            // tscdCortar
            // 
            this.tscdCortar.Name = "tscdCortar";
            this.tscdCortar.Size = new System.Drawing.Size(139, 24);
            this.tscdCortar.Text = "Cortar";
            // 
            // tscdCopiar
            // 
            this.tscdCopiar.Name = "tscdCopiar";
            this.tscdCopiar.Size = new System.Drawing.Size(139, 24);
            this.tscdCopiar.Text = "Copiar";
            // 
            // tscdPegar
            // 
            this.tscdPegar.Name = "tscdPegar";
            this.tscdPegar.Size = new System.Drawing.Size(139, 24);
            this.tscdPegar.Text = "Pegar";
            // 
            // tscdCerrar
            // 
            this.tscdCerrar.Name = "tscdCerrar";
            this.tscdCerrar.Size = new System.Drawing.Size(139, 24);
            this.tscdCerrar.Text = "Cerrar";
            // 
            // tsEditorHijo
            // 
            this.tsEditorHijo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEditorHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bhbtGuardar,
            this.bhbtGuardarComo,
            this.tsSeparador,
            this.bhbtDeshacer,
            this.bhbtRehacer,
            this.bhbtCortar,
            this.bhbtCopiar,
            this.bhbtPegar,
            this.tsbtSeleccionarTodo});
            this.tsEditorHijo.Location = new System.Drawing.Point(0, 0);
            this.tsEditorHijo.Name = "tsEditorHijo";
            this.tsEditorHijo.Size = new System.Drawing.Size(1067, 27);
            this.tsEditorHijo.TabIndex = 3;
            this.tsEditorHijo.Text = "tsEditorHijo";
            this.tsEditorHijo.Visible = false;
            // 
            // bhbtGuardar
            // 
            this.bhbtGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtGuardar.Image = ((System.Drawing.Image)(resources.GetObject("bhbtGuardar.Image")));
            this.bhbtGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtGuardar.MergeIndex = 2;
            this.bhbtGuardar.Name = "bhbtGuardar";
            this.bhbtGuardar.Size = new System.Drawing.Size(29, 24);
            this.bhbtGuardar.Text = "Guardar";
            this.bhbtGuardar.Click += new System.EventHandler(this.tsmiGuardar_Click);
            // 
            // bhbtGuardarComo
            // 
            this.bhbtGuardarComo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtGuardarComo.Image = ((System.Drawing.Image)(resources.GetObject("bhbtGuardarComo.Image")));
            this.bhbtGuardarComo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtGuardarComo.Name = "bhbtGuardarComo";
            this.bhbtGuardarComo.Size = new System.Drawing.Size(29, 24);
            this.bhbtGuardarComo.Text = "Guardar como";
            this.bhbtGuardarComo.Click += new System.EventHandler(this.tsmiGuardarComo_Click);
            // 
            // tsSeparador
            // 
            this.tsSeparador.Name = "tsSeparador";
            this.tsSeparador.Size = new System.Drawing.Size(6, 27);
            // 
            // bhbtDeshacer
            // 
            this.bhbtDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("bhbtDeshacer.Image")));
            this.bhbtDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtDeshacer.Name = "bhbtDeshacer";
            this.bhbtDeshacer.Size = new System.Drawing.Size(29, 24);
            this.bhbtDeshacer.Text = "Deshacer";
            this.bhbtDeshacer.Click += new System.EventHandler(this.tsmiDeshacer_Click);
            // 
            // bhbtRehacer
            // 
            this.bhbtRehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtRehacer.Image = ((System.Drawing.Image)(resources.GetObject("bhbtRehacer.Image")));
            this.bhbtRehacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtRehacer.Name = "bhbtRehacer";
            this.bhbtRehacer.Size = new System.Drawing.Size(29, 24);
            this.bhbtRehacer.Text = "Rehacer";
            this.bhbtRehacer.Click += new System.EventHandler(this.tsmiRehacer_Click);
            // 
            // bhbtCortar
            // 
            this.bhbtCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtCortar.Image = ((System.Drawing.Image)(resources.GetObject("bhbtCortar.Image")));
            this.bhbtCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtCortar.Name = "bhbtCortar";
            this.bhbtCortar.Size = new System.Drawing.Size(29, 24);
            this.bhbtCortar.Text = "Cortar";
            this.bhbtCortar.Click += new System.EventHandler(this.tsmiCortar_Click);
            // 
            // bhbtCopiar
            // 
            this.bhbtCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtCopiar.Image = ((System.Drawing.Image)(resources.GetObject("bhbtCopiar.Image")));
            this.bhbtCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtCopiar.Name = "bhbtCopiar";
            this.bhbtCopiar.Size = new System.Drawing.Size(29, 24);
            this.bhbtCopiar.Text = "Copiar";
            this.bhbtCopiar.Click += new System.EventHandler(this.tsmiCopiar_Click);
            // 
            // bhbtPegar
            // 
            this.bhbtPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bhbtPegar.Image = ((System.Drawing.Image)(resources.GetObject("bhbtPegar.Image")));
            this.bhbtPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bhbtPegar.Name = "bhbtPegar";
            this.bhbtPegar.Size = new System.Drawing.Size(29, 24);
            this.bhbtPegar.Text = "Pegar";
            this.bhbtPegar.Click += new System.EventHandler(this.tsmiPegar_Click);
            // 
            // tsmiRehacer
            // 
            this.tsmiRehacer.Name = "tsmiRehacer";
            this.tsmiRehacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRehacer.Size = new System.Drawing.Size(254, 26);
            this.tsmiRehacer.Text = "Rehacer";
            this.tsmiRehacer.Click += new System.EventHandler(this.tsmiRehacer_Click);
            // 
            // tsmiSeleccionarTodo
            // 
            this.tsmiSeleccionarTodo.Name = "tsmiSeleccionarTodo";
            this.tsmiSeleccionarTodo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiSeleccionarTodo.Size = new System.Drawing.Size(254, 26);
            this.tsmiSeleccionarTodo.Text = "Seleccionar todo";
            // 
            // tsbtSeleccionarTodo
            // 
            this.tsbtSeleccionarTodo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtSeleccionarTodo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtSeleccionarTodo.Image")));
            this.tsbtSeleccionarTodo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtSeleccionarTodo.Name = "tsbtSeleccionarTodo";
            this.tsbtSeleccionarTodo.Size = new System.Drawing.Size(29, 24);
            this.tsbtSeleccionarTodo.Text = "Seleccionar todo";
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ContextMenuStrip = this.cmsMenuContextualHijo;
            this.Controls.Add(this.tsEditorHijo);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.msMenuHijo);
            this.MainMenuStrip = this.msMenuHijo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHijo";
            this.Text = "FormHijo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHijo_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHijo_FormClosed);
            this.msMenuHijo.ResumeLayout(false);
            this.msMenuHijo.PerformLayout();
            this.cmsMenuContextualHijo.ResumeLayout(false);
            this.tsEditorHijo.ResumeLayout(false);
            this.tsEditorHijo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.MenuStrip msMenuHijo;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdicion;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeshacer;
        private System.Windows.Forms.ToolStripMenuItem tsmiCortar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsmiPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsMenuContextualHijo;
        private System.Windows.Forms.ToolStripMenuItem tscdDeshacer;
        private System.Windows.Forms.ToolStripMenuItem tscdCortar;
        private System.Windows.Forms.ToolStripMenuItem tscdCopiar;
        private System.Windows.Forms.ToolStripMenuItem tscdPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tscdCerrar;
        private System.Windows.Forms.ToolStrip tsEditorHijo;
        private System.Windows.Forms.ToolStripButton bhbtGuardar;
        private System.Windows.Forms.ToolStripButton bhbtGuardarComo;
        private System.Windows.Forms.ToolStripSeparator tsSeparador;
        private System.Windows.Forms.ToolStripButton bhbtDeshacer;
        private System.Windows.Forms.ToolStripButton bhbtRehacer;
        private System.Windows.Forms.ToolStripButton bhbtCortar;
        private System.Windows.Forms.ToolStripButton bhbtCopiar;
        private System.Windows.Forms.ToolStripButton bhbtPegar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRehacer;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeleccionarTodo;
        private System.Windows.Forms.ToolStripButton tsbtSeleccionarTodo;
    }
}