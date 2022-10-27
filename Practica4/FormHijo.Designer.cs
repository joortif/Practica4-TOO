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
            this.tsmiCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenuHijo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(0, 24);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(800, 426);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCerrar.Location = new System.Drawing.Point(340, 409);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(71, 29);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // msMenuHijo
            // 
            this.msMenuHijo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivo,
            this.tsmiEdicion});
            this.msMenuHijo.Location = new System.Drawing.Point(0, 0);
            this.msMenuHijo.Name = "msMenuHijo";
            this.msMenuHijo.Size = new System.Drawing.Size(800, 24);
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
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiGuardar
            // 
            this.tsmiGuardar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiGuardar.MergeIndex = 2;
            this.tsmiGuardar.Name = "tsmiGuardar";
            this.tsmiGuardar.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardar.Text = "Guardar";
            // 
            // tsmiGuardarComo
            // 
            this.tsmiGuardarComo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiGuardarComo.MergeIndex = 3;
            this.tsmiGuardarComo.Name = "tsmiGuardarComo";
            this.tsmiGuardarComo.Size = new System.Drawing.Size(180, 22);
            this.tsmiGuardarComo.Text = "Guardar como";
            // 
            // tsmiCerrar
            // 
            this.tsmiCerrar.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.tsmiCerrar.MergeIndex = 5;
            this.tsmiCerrar.Name = "tsmiCerrar";
            this.tsmiCerrar.Size = new System.Drawing.Size(180, 22);
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
            this.tsmiEdicion.MergeIndex = 2;
            this.tsmiEdicion.Name = "tsmiEdicion";
            this.tsmiEdicion.Size = new System.Drawing.Size(58, 20);
            this.tsmiEdicion.Text = "Edición";
            // 
            // tsmiDeshacer
            // 
            this.tsmiDeshacer.Name = "tsmiDeshacer";
            this.tsmiDeshacer.Size = new System.Drawing.Size(180, 22);
            this.tsmiDeshacer.Text = "Deshacer";
            // 
            // tsmiCortar
            // 
            this.tsmiCortar.Name = "tsmiCortar";
            this.tsmiCortar.Size = new System.Drawing.Size(180, 22);
            this.tsmiCortar.Text = "Cortar";
            // 
            // tsmiCopiar
            // 
            this.tsmiCopiar.Name = "tsmiCopiar";
            this.tsmiCopiar.Size = new System.Drawing.Size(180, 22);
            this.tsmiCopiar.Text = "Copiar";
            // 
            // tsmiPegar
            // 
            this.tsmiPegar.Name = "tsmiPegar";
            this.tsmiPegar.Size = new System.Drawing.Size(180, 22);
            this.tsmiPegar.Text = "Pegar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripSeparator1.MergeIndex = 4;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.rtbTexto);
            this.Controls.Add(this.msMenuHijo);
            this.MainMenuStrip = this.msMenuHijo;
            this.Name = "FormHijo";
            this.Text = "FormHijo";
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
    }
}