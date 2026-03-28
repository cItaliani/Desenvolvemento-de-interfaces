using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Prueba de escritura de texto", this.Font, Brushes.BlueViolet, 10, 10);
        
         
        }

        private void labelTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {

        }
    }
}
