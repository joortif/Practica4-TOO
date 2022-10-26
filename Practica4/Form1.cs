using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4
{
    public partial class FormPrincipal : Form
    {

        private int numForms = 0;
        private ToolStripDropDownItem[] desplegables;
        public FormPrincipal()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            IsMdiContainer = true;
            desplegables = new ToolStripDropDownItem[4];
            desplegables[0] = smArrangItems;
            desplegables[1] = smCascada;
            desplegables[2] = smHorizontal;
            desplegables[3] = smVertical;
        }

        private void smSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smNuevo_Click(object sender, EventArgs e)
        {
            numForms++;
            Form FormHijo = new FormHijo();
            FormHijo.Text = "Documento " + numForms;
            msMenu.MdiWindowListItem = smVentana;
            FormHijo.Show();
            FormHijo.MdiParent = this;
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

        private void smVentana_DropDownOpening(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
            {
                smVentana.DropDownItems.Clear();
            }
            else
            {
                smVentana.DropDownItems.AddRange(desplegables);

            }
        }
    }
}