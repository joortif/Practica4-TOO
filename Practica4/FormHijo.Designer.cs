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
            this.SuspendLayout();
            // 
            // rtbTexto
            // 
            this.rtbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexto.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTexto.Location = new System.Drawing.Point(0, 0);
            this.rtbTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbTexto.Name = "rtbTexto";
            this.rtbTexto.Size = new System.Drawing.Size(1067, 554);
            this.rtbTexto.TabIndex = 0;
            this.rtbTexto.Text = "";
            // 
            // btCerrar
            // 
            this.btCerrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCerrar.Location = new System.Drawing.Point(453, 503);
            this.btCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(95, 36);
            this.btCerrar.TabIndex = 1;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // FormHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.rtbTexto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormHijo";
            this.Text = "FormHijo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHijo_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbTexto;
        private System.Windows.Forms.Button btCerrar;
    }
}