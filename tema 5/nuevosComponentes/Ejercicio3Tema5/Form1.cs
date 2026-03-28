using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio3Tema5
{
    public partial class Form1 : Form
    {
        string[] imagenes;
        int indice=0;
        

        
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            for (int i = 1; i <= 20; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 9;
        }



        private void controlMultimedia1_DesbordaTiempo(object sender, EventArgs e)
        {
            controlMultimedia1.minutos++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            {
                if (!Directory.Exists(textBox1.Text))
                {
                    return;
                }
                else
                {
                    imagenes = Directory.GetFiles(textBox1.Text).Where(nombre =>
                    nombre.EndsWith(".jpg") || nombre.EndsWith(".png")).ToArray();
                    if (imagenes.Length>0)
                    {
                        pictureBox1.ImageLocation = imagenes[0];
                        indice = 0;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            controlMultimedia1.segundos++;
            if (imagenes==null||imagenes.Length ==0)
            {
                return;
            }
            indice++;
            if (imagenes.Length<=indice)
            {
                indice = 0;
            }
            pictureBox1.ImageLocation = imagenes[indice];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tiempo = (int)comboBox1.SelectedItem;
            timer1.Interval = tiempo * 1000;
            timer1.Start();
        }


        private void controlMultimedia1_PlayClick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
