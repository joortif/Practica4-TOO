using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica4
{
    public partial class FormHijo : Form
    {
        public FormHijo(String nombre)
        {
            InitializeComponent();
            
        }

        private void FormHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se ha cerrado " + this.Text, "Aviso");
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
