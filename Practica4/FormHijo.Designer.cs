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
            this.msMenuHijo.SuspendLayout();
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
            this.tsmiGuardar.Size = new System.Drawing.Size(187, 26);
            this.tsmiGuardar.Text = "Guardar";
            this.tsmiGuardar.Click += new System.EventHandler(this.tsmiGuardar_Click);
            // 
            // tsmiGuardarComo
            // 
            this.tsmiGuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiGuardarComo.MergeIndex = 3;
            this.tsmiGuardarComo.Name = "tsmiGuardarComo";
            this.tsmiGuardarComo.Size = new System.Drawing.Size(187, 26);
            this.tsmiGuardarComo.Text = "Guardar como";
            this.tsmiGuardarComo.Click += new System.EventHandler(this.tsmiGuardarComo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 4;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // tsmiCerrar
            // 
            this.tsmiCerrar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiCerrar.MergeIndex = 5;
            this.tsmiCerrar.Name = "tsmiCerrar";
            this.tsmiCerrar.Size = new System.Drawing.Size(187, 26);
            this.tsmiCerrar.Text = "Cerrar";
            // 
            // tsmiEdicion
            // 
            this.tsmiEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeshacer,
            this.toolStripSeparator2,
            this.tsmiCortar,
            this.tsmiCopiar,
            this.tsmiPegar});
            this.tsmiEdicion.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiEdicion.MergeIndex = 1;
            this.tsmiEdicion.Name = "tsmiEdicion";
            this.tsmiEdicion.Size = new System.Drawing.Size(72, 24);
            this.tsmiEdicion.Text = "Edición";
            // 
            // tsmiDeshacer
            // 
            this.tsmiDeshacer.Name = "tsmiDeshacer";
            this.tsmiDeshacer.Size = new System.Drawing.Size(153, 26);
            this.tsmiDeshacer.Text = "Deshacer";
            this.tsmiDeshacer.Click += new System.EventHandler(this.tsmiDeshacer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(150, 6);
            // 
            // tsmiCortar
            // 
            this.tsmiCortar.Name = "tsmiCortar";
            this.tsmiCortar.Size = new System.Drawing.Size(153, 26);
            this.tsmiCortar.Text = "Cortar";
            this.tsmiCortar.Click += new System.EventHandler(this.tsmiCortar_Click);
            // 
            // tsmiCopiar
            // 
            this.tsmiCopiar.Name = "tsmiCopiar";
            this.tsmiCopiar.Size = new System.Drawing.Size(153, 26);
            this.tsmiCopiar.Text = "&Copiar";
            this.tsmiCopiar.Click += new System.EventHandler(this.tsmiCopiar_Click);
            // 
            // tsmiPegar
            // 
            this.tsmiPegar.Name = "tsmiPegar";
            this.tsmiPegar.Size = new System.Drawing.Size(153, 26);
            this.tsmiPegar.Text = "Pegar";
            this.tsmiPegar.Click += new System.EventHandler(this.tsmiPegar_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.fuenteToolStripMenuItem.Text = "Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
    }
}