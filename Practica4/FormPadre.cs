using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class FormPrincipal : Form
    {

        private int numForms = 0;
        public FormPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            smVentana.Visible = false;

            foreach (ToolStripMenuItem opcion in msMenu.Items)
            {
                opcion.MouseHover += Opcion_MouseEnter;
                foreach (ToolStripDropDownItem opcion2 in opcion.DropDownItems)
                {
                    opcion2.MouseHover += Opcion_MouseEnter;
                }
            }

        }

        private void Opcion_MouseEnter(object sender, EventArgs e)
        {
            tslSeleccionado.Text = sender.ToString();
        }

        private void smSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smNuevo_Click(object sender, EventArgs e)
        {
            numForms++;
            Form fHijo = new FormHijo("");
            fHijo.Text = "Documento " + numForms;
            fHijo.Show();
            fHijo.MdiParent = this;

            foreach (ToolStripMenuItem opcion in msMenu.Items)
            {
                opcion.MouseHover += Opcion_MouseEnter;
                foreach (ToolStripItem opcion2 in opcion.DropDownItems)
                {
                    if (opcion2 is ToolStripDropDownItem)
                    {
                        opcion2.MouseHover += Opcion_MouseEnter;
                    }
                    
                }
            }

        }

        private void smArrangItems_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void smCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void smHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void smVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mostrarOpcionInferior()
        {
            foreach (ToolStripMenuItem opcion in msMenu.Items)
            {
                opcion.MouseHover += Opcion_MouseEnter;
                foreach (ToolStripDropDownItem opcion2 in opcion.DropDownItems)
                {
                    opcion2.MouseHover += Opcion_MouseEnter;
                }
            }
        }
        private void FormPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                smVentana.Visible = false;
                tslDocumento.Text = null;
            }
            else
            {
                smVentana.Visible = true;
                tslDocumento.Text = ActiveMdiChild.Text;

            }


        }

        private void tsmiBarraEstado_Click(object sender, EventArgs e)
        {
            if (tsmiBarraEstado.Checked)
            {
                ssBarraEstado.Visible = true;
            } else
            {
                ssBarraEstado.Visible = false;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Seleccione el archivo a abrir";
            ofd.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            ofd.FileName = ofd.InitialDirectory;
            
            DialogResult pulsado = ofd.ShowDialog();
            if (pulsado == DialogResult.OK)
            {
                FormHijo fHijo = new FormHijo(ofd.FileName);
                fHijo.MdiParent = this;
                String[] trozos = fHijo.Ruta.Split(Path.DirectorySeparatorChar);
                String[] trozosNombre = trozos[trozos.Length - 1].Split('.');
                if (trozosNombre[trozosNombre.Length-1] == "txt")
                {
                    fHijo.RtbTexto.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                } else if (trozosNombre[trozos.Length-1] == "rtf")
                {
                    fHijo.RtbTexto.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                fHijo.Text = trozos[trozos.Length - 1];
                fHijo.Show();
                
            }
            ofd.Dispose();




        }
    }
}