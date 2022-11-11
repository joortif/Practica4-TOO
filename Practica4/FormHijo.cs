using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica4
{
    public partial class FormHijo : Form
    {
        private String ruta;
        private bool modificado = false;

        public RichTextBox RtbTexto
        {
            get
            {
                return this.rtbTexto;
            }
        }

        public String Ruta
        {
            get
            {
                return this.ruta;
            }
        }

        public ToolStrip TsEditorHijo
        {
            get
            {
                return this.tsEditorHijo;
            }
        }


        public FormHijo(String nombre)
        {
            InitializeComponent();
            this.ruta = nombre;
        }

        private void FormHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se ha cerrado " + this.Text, "Aviso");
            
        }

        private void FormHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.rtbTexto.Modified == true)
            {
                DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar cambios?", "Aviso", MessageBoxButtons.YesNoCancel);
                if (resultado == DialogResult.Yes)
                {

                } else if (resultado == DialogResult.No)
                {
                    tsmiGuardar.PerformClick();
                } else if (resultado == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            } 
            

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiGuardar_Click(object sender, EventArgs e)
        {
            if (this.ruta == "")
            {
                tsmiGuardarComo.PerformClick();
            } else
            {
                String[] trozos = this.ruta.Split(Path.DirectorySeparatorChar);
                String[] nombre = trozos[trozos.Length - 1].Split('.');
                if (nombre[nombre.Length-1] == "txt")
                {
                    this.rtbTexto.SaveFile(this.ruta, RichTextBoxStreamType.PlainText);
                } else if (nombre[nombre.Length - 1] == "rtf")
                {
                    this.rtbTexto.LoadFile(this.ruta, RichTextBoxStreamType.RichText);
                }
                
            }
        }

        private void tsmiGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog cuadroGuardar = new SaveFileDialog();
            cuadroGuardar.Title = "Seleccione el archivo a guardar";
            cuadroGuardar.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            cuadroGuardar.FileName = this.Text;


            cuadroGuardar.DefaultExt = "txt"; //Por defecto la extensión será .txt
           
            DialogResult pulsado = cuadroGuardar.ShowDialog();
            if (pulsado == DialogResult.OK)
            {
                String nombreYExt = cuadroGuardar.FileName.Split(Path.DirectorySeparatorChar).Last();
                String ext = nombreYExt.Split('.').Last();
                if (ext == "rtf")
                {
                    this.rtbTexto.SaveFile(cuadroGuardar.FileName, RichTextBoxStreamType.RichText);
                } else if (ext == "txt")
                {
                    this.rtbTexto.SaveFile(cuadroGuardar.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = nombreYExt;
                this.rtbTexto.Modified = false;
            } 
        }

        private void tsmiDeshacer_Click(object sender, EventArgs e)
        {
            this.rtbTexto.Undo();
        }

        private void tsmiCortar_Click(object sender, EventArgs e)
        {
            this.rtbTexto.Cut();
        }

        private void tsmiCopiar_Click(object sender, EventArgs e)
        {
            this.rtbTexto.Copy();
        }

        private void tsmiPegar_Click(object sender, EventArgs e)
        {
            this.rtbTexto.Paste();
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog cuadroFuentes = new FontDialog();
            cuadroFuentes.ShowColor = true;
            cuadroFuentes.Font = this.rtbTexto.Font;
            DialogResult resultado = cuadroFuentes.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                this.rtbTexto.Font = cuadroFuentes.Font;
                this.rtbTexto.ForeColor = cuadroFuentes.Color;
            }
        }

        private void rtbTexto_TextChanged(object sender, EventArgs e)
        {
            if (!this.modificado)
            {
                this.modificado = true;
            } else
            {
                this.rtbTexto.TextChanged -= this.rtbTexto_TextChanged;
            }
            
        }

        private void tsmiCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsmiRehacer_Click(object sender, EventArgs e)
        {
            this.rtbTexto.Redo();
        }

        
    }
}
