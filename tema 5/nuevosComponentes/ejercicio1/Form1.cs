using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == nuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA)
            {
                labelTextBox1.Posicion = nuevosComponentes.LabelTextBox.EPosicion.DERECHA;
            }
            else
            {
                labelTextBox1.Posicion = nuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
