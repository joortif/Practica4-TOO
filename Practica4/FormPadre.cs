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
        bool merged = false;

        public ToolStrip TsEditorPadre
        {
            get
            {
                return this.tsEditorPadre;
            }
        }
       
        public FormPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            smVentana.Visible = false;
            this.tsmiCerrarDocs.Enabled = false;


        }

        

        private void smSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smNuevo_Click(object sender, EventArgs e)
        {
            numForms++;
            FormHijo fHijo = new FormHijo("");
            fHijo.Text = "Documento " + numForms;
            fHijo.MdiParent = this;
            if (!this.merged)
            {
                this.merged = ToolStripManager.Merge(fHijo.TsEditorHijo, this.tsEditorPadre);

            }
            
            fHijo.Show();

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

        private void FormPrincipal_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                smVentana.Visible = false;
                tslDocumento.Text = null;
                if (this.merged)
                {
                    ToolStripManager.RevertMerge(this.tsEditorPadre);
                    this.merged = false;
                }
                this.tsmiCerrarDocs.Enabled = false;
            }
            else
            {
                smVentana.Visible = true;
                tslDocumento.Text = ActiveMdiChild.Text;
                this.tsmiCerrarDocs.Enabled = true;
                FormHijo hijo = (FormHijo)this.ActiveMdiChild;
                foreach (ToolStripItem item in hijo.RtbTexto.ContextMenuStrip.Items)
                {
                    if (item is ToolStripMenuItem)
                    {
                        item.MouseHover -= ToolStripItem_MouseHover;
                        item.MouseLeave -= ToolStripItem_MouseLeave;
                        item.MouseHover += ToolStripItem_MouseHover;
                        item.MouseLeave += ToolStripItem_MouseLeave;
                    }
                }

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
                String nombreCompleto = fHijo.Ruta.Split(Path.DirectorySeparatorChar).Last();
                String ext = nombreCompleto.Split('.').Last();
                if (ext == "txt")
                {
                    fHijo.RtbTexto.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                }
                else if (ext == "rtf")
                {
                    fHijo.RtbTexto.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                }
                fHijo.Text = nombreCompleto;
                fHijo.Modificado = false;
                fHijo.Show();
               
                
            }
            ofd.Dispose();

        }
        private void ToolStripItem_MouseLeave(object sender, EventArgs e)
        {
            this.tslSeleccionado.Text = "";
        }

        private void ToolStripItem_MouseHover(object sender, EventArgs e)
        {
            ToolStripItem t = sender as ToolStripItem;
            if (t != null)
            {
                this.tslSeleccionado.Text = t.Text;
            }
        }

        private void CargarEventos()
        {
            foreach (ToolStripMenuItem opcion in this.msMenu.Items)
            {
                opcion.MouseHover -= ToolStripItem_MouseHover;
                opcion.MouseLeave -= ToolStripItem_MouseLeave;
                opcion.MouseHover += ToolStripItem_MouseHover;
                opcion.MouseLeave += ToolStripItem_MouseLeave;
                foreach (ToolStripItem opcion2 in opcion.DropDownItems)
                {
                    if (opcion2 is ToolStripMenuItem)
                    {
                        opcion2.MouseHover -= ToolStripItem_MouseHover;
                        opcion2.MouseLeave -= ToolStripItem_MouseLeave;
                        opcion2.MouseHover += ToolStripItem_MouseHover;
                        opcion2.MouseLeave += ToolStripItem_MouseLeave;
                    }
                    
                }
            }
            foreach (ToolStripItem item in this.tsEditorPadre.Items)
            {
                if (item is ToolStripButton)
                {
                    item.MouseHover -= ToolStripItem_MouseHover;
                    item.MouseLeave -= ToolStripItem_MouseLeave;
                    item.MouseHover += ToolStripItem_MouseHover;
                    item.MouseLeave += ToolStripItem_MouseLeave;
                }
            }
            foreach (ToolStripItem item in this.cmsMenuContextualPadre.Items)
            {
                if (item is ToolStripMenuItem)
                {
                    item.MouseHover -= ToolStripItem_MouseHover;
                    item.MouseLeave -= ToolStripItem_MouseLeave;
                    item.MouseHover += ToolStripItem_MouseHover;
                    item.MouseLeave += ToolStripItem_MouseLeave;
                }
            }
       
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.CargarEventos();
        }

        private void FormPrincipal_Layout(object sender, LayoutEventArgs e)
        {
            this.CargarEventos();
            
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsmiCerrarDocs_Click(object sender, EventArgs e)
        {
            foreach (Form hijo in this.MdiChildren){
                hijo.Close();
                hijo.Dispose();
            }
        }
    }
}