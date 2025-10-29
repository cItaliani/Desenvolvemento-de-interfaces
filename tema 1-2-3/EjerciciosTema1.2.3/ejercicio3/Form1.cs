#define PRUEBA
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        int nMin = 1;
        int nMax = 7;
        int bote = 50;
        Random generador = new Random();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bote = bote + 10;
            label2.Text = String.Format(bote + "€");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//TODO revisar uso tuplas y funcion // revisado 
        {

            (int a, int b, int c) = numerosAleatorios(nMin,nMax);
            bote = bote - 2;
            label2.Text = bote + "€";
            textBox1.Text = a.ToString();// String.Format("{0}", a);
            textBox2.Text = String.Format("{0}", b);
            textBox3.Text = String.Format("{0}", c);
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox3.TextAlign = HorizontalAlignment.Center;

            if (textBox1.Text == textBox2.Text && textBox1.Text == textBox3.Text)
            {
                bote = bote + 20;
                label2.Text = String.Format(bote + "€");
                label1.Text = ("enhorabuena, has ganado 20€");
            }

            else if (textBox1.Text == textBox2.Text || textBox2.Text == textBox3.Text || textBox1.Text == textBox3.Text)
            {

#if PRUEBA
                bote = bote + 5;
                label2.Text = String.Format(bote + "€");
                label1.Text = ("enhorabuena, has ganado 5€");
            }
            else
            {
                label1.Text = "lo lamento, tu jugada no ha sido premiada";
            }
        }
#else
                bote = bote - 5;
                label2.Text = String.Format(bote + "€");
                label1.Text = ("lo lamento, pierdes 5€");
            }
            else
            {
                label1.Text = "lo lamento, tu jugada no ha sido premiada";
            }
        }
#endif       

        public (int, int, int) numerosAleatorios(int nMin, int nMax)
        {
            int x = generador.Next(nMin, nMax);
            int y;
            int z;
       
            y = generador.Next(nMin,nMax);
            z = generador.Next(nMin,nMax);
            return (x, y, z);
        }

    }
}