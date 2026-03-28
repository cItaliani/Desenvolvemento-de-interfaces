using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2tema5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            etiquetaAviso3.clickEnMarca += (s, ev) => { MessageBox.Show("Se ha ejecurado el evento", "", MessageBoxButtons.OK);};
        }

        private void etiquetaAviso3_Click(object sender, EventArgs e)
        {

        }

        private void etiquetaAviso5_Click(object sender, EventArgs e)
        {

        }
    }
}
