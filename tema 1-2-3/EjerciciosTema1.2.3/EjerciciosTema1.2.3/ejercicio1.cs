using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EjerciciosTema1._2._3
{
    public partial class Ejercicio1 : Form
     
  
    {

        public Ejercicio1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =  Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int resultado = a + b;
            label2.Text = String.Format("="+resultado);

        }
    }
        
        }
