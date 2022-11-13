using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        private bool modificado;

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

        public bool Modificado
        {
            set
            {
                this.modificado = value;
            }
        }


        public FormHijo(String nombre)
        {
            InitializeComponent();
            this.ruta = nombre;
            
            this.modificado = false;
        }

        private void FormHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se ha cerrado " + this.Text, "Aviso");
            
        }

        private void FormHijo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.modificado == true)
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
                    this.modificado = false;
                } else if (nombre[nombre.Length - 1] == "rtf")
                {
                    this.rtbTexto.SaveFile(this.ruta, RichTextBoxStreamType.RichText);
                    this.modificado = false;
                }
                
            }
        }

        private void tsmiGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog cuadroGuardar = new SaveFileDialog();
            cuadroGuardar.AddExtension = false;
            cuadroGuardar.Title = "Seleccione el archivo a guardar";
            cuadroGuardar.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*|Formato de texto rico|*.rtf";
            cuadroGuardar.FileName = this.Text;
            
           
            DialogResult pulsado = cuadroGuardar.ShowDialog();
            if (pulsado == DialogResult.OK)
            {
                String nombreYExt = cuadroGuardar.FileName.Split(Path.DirectorySeparatorChar).Last();
                String ext = nombreYExt.Split('.').Last();
                if (ext == "rtf")
                {
                    this.rtbTexto.SaveFile(cuadroGuardar.FileName, RichTextBoxStreamType.RichText);
                    this.Text = nombreYExt;
                    this.modificado = false;
                } else if (ext == "txt")
                {
                    this.rtbTexto.SaveFile(cuadroGuardar.FileName, RichTextBoxStreamType.PlainText);
                    this.Text = nombreYExt;
                    this.modificado = false;
                } else
                {
                    MessageBox.Show("Indique la extensión correspondiente del archivo (.rtf o .txt)", "Aviso");
                }
                
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

        private void tsmiBorrar_Click(object sender, EventArgs e)
        {
            this.rtbTexto.SelectedText = "";
        }

        private void tsmiSeleccionarTodo_Click(object sender, EventArgs e)
        {
            this.rtbTexto.SelectAll();
        }


        private void ActivarMenuContextualRtb(RichTextBox rtb)
        {
            if (rtb.ContextMenu == null)
            {
                ContextMenuStrip mc = new ContextMenuStrip();
                

                //Deshacer
                ToolStripMenuItem tsmiDeshacer = new ToolStripMenuItem("Deshacer");
                tsmiDeshacer.Click += this.tsmiDeshacer_Click;
                mc.Items.Add(tsmiDeshacer);

                //Rehacer
                ToolStripMenuItem tsmiRehacer = new ToolStripMenuItem("Rehacer");
                tsmiRehacer.Click += this.tsmiRehacer_Click;
                mc.Items.Add(tsmiRehacer);

                //Separador
                mc.Items.Add(new ToolStripSeparator());

                //Cortar
                ToolStripMenuItem tsmiCortar = new ToolStripMenuItem("Cortar");
                tsmiCortar.Click += this.tsmiCortar_Click;
                mc.Items.Add(tsmiCortar);

                //Copiar
                ToolStripMenuItem tsmiCopiar = new ToolStripMenuItem("Copiar");
                tsmiCopiar.Click += this.tsmiCopiar_Click;
                mc.Items.Add(tsmiCopiar);

                //Pegar
                ToolStripMenuItem tsmiPegar = new ToolStripMenuItem("Pegar");
                tsmiPegar.Click += this.tsmiPegar_Click;
                mc.Items.Add(tsmiPegar);

                //Borrar
                ToolStripMenuItem tsmiBorrar = new ToolStripMenuItem("Borrar");
                tsmiBorrar.Click += this.tsmiBorrar_Click;
                mc.Items.Add(tsmiBorrar);

                //Separador 2
                mc.Items.Add(new ToolStripSeparator());

                //Seleccionar todo
                ToolStripMenuItem tsmiSeleccionarTodo = new ToolStripMenuItem("Seleccionar todo");
                tsmiSeleccionarTodo.Click += this.tsmiSeleccionarTodo_Click;
                mc.Items.Add(tsmiSeleccionarTodo);

                mc.Opening += (s, ev) =>
                {
                    bool seleccionado = this.rtbTexto.SelectionLength > 0;

                    tsmiDeshacer.Enabled = this.rtbTexto.CanUndo;
                    tsmiRehacer.Enabled = this.rtbTexto.CanRedo;
                    tsmiCortar.Enabled = seleccionado;
                    tsmiCopiar.Enabled = seleccionado;
                    tsmiPegar.Enabled = Clipboard.ContainsText();
                    tsmiBorrar.Enabled = seleccionado;
                    tsmiSeleccionarTodo.Enabled = this.rtbTexto.TextLength > 0 && this.rtbTexto.SelectionLength < this.rtbTexto.TextLength;
                };

                this.rtbTexto.ContextMenuStrip = mc;

            }
        }


        private void tsmiEdicion_DropDownOpening(object sender, EventArgs e)
        {
            bool seleccionado = this.rtbTexto.SelectionLength > 0;

            this.tsmiDeshacer.Enabled = this.rtbTexto.CanUndo;
            this.tsmiRehacer.Enabled = this.rtbTexto.CanRedo;
            this.tsmiCortar.Enabled = seleccionado;
            this.tsmiCopiar.Enabled = seleccionado;
            this.tsmiPegar.Enabled = Clipboard.ContainsText();
            this.tsmiBorrar.Enabled = seleccionado;
            this.tsmiSeleccionarTodo.Enabled = this.rtbTexto.TextLength > 0 && this.rtbTexto.SelectionLength < this.rtbTexto.TextLength;

        }

        private void FormHijo_Activated(object sender, EventArgs e)
        {
            FormPrincipal fPadre = (FormPrincipal)this.MdiParent;
            ToolStripManager.RevertMerge(fPadre.TsEditorPadre);
            ToolStripManager.Merge(this.TsEditorHijo, fPadre.TsEditorPadre);
        }

        private void FormHijo_Load(object sender, EventArgs e)
        {
            this.ActivarMenuContextualRtb(this.rtbTexto);
        }
    }
}
