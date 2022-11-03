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
        private String ruta;

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

        public FormHijo(String nombre)
        {
            InitializeComponent();
            this.ruta = nombre;
       
        }

        private void FormHijo_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Se ha cerrado " + this.Text, "Aviso");
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiGuardar_Click(object sender, EventArgs e)
        {
            //if ()
            //{
            //    tsmiGuardarComo.PerformClick();
            //} else
            //{

            //}
            
        }

        private void tsmiGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog cuadroGuardar = new SaveFileDialog();
            cuadroGuardar.Title = "Seleccione el archivo a guardar";
            cuadroGuardar.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            cuadroGuardar.DefaultExt = "*.rtf";

            


        }
    }
}
