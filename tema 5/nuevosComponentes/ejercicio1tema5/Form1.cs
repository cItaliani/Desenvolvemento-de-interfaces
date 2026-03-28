using System;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio1tema5
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

   
        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == nuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA)
            {
                this.Text = "IZQUIERDA";
            }
            else
            {
                this.Text = "DERECHA";
            }
        }

        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {
            this.Text = "Separación: " + labelTextBox1.Separacion.ToString();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion < this.Width)
            {
                labelTextBox1.Separacion += 5;
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion > 0)
            {
                labelTextBox1.Separacion -= 5;
            }
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        int contador = 0;
        private void labelTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            contador++;
            if (contador % 2 == 1)
            {
                this.BackColor = Color.LightGreen;
            }
            else
            {
                this.BackColor = Color.Empty;
            }
        }
    }
}