using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio1
{
    
    public partial class Form1 : Form
    {
        private string titulo;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            titulo = "Mouse Tester";

           
            this.MouseMove += Form1_MouseMove;
            this.MouseLeave += Form1_MouseLeave;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.KeyPress += Form1_KeyPress;
            this.FormClosing += Form1_FormClosing;

            creaBotones();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           
            float coordenadaX = e.X;
            float coordenadaY = e.Y;
            this.Text = $"coordenada X: {coordenadaX} | coordenada Y: {coordenadaY}";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = titulo;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                button1.Text = "Wheel";
                button2.BackColor = Color.Green;
                button2.ForeColor = Color.White;
                button2.Text = "Wheel";

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
            }
            else
            {
                button1.BackColor = Color.White;
                button1.ForeColor = Color.Black;
                button1.Text = "Izquierdo";
                button2.BackColor = Color.White;
                button2.ForeColor = Color.Black;
                button2.Text = "Derecho";
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)27)
                this.Text = $"Tecla pulsada: {e.KeyChar}";
            else
                this.Text = titulo;
        }

        public void creaBotones()
        {
            int x = 80;
            int y = 100;
            int ancho = 50;
            int alto = 30;

            for (int i = 1; i <= 20; i++)
            {
                Button boton = new Button();
                boton.Text = i.ToString();
                boton.Location = new Point(x, y);
                boton.Size = new Size(ancho, alto);

               
                boton.MouseMove += (sender, e) =>
                {

                    int x1 = e.X+((Button)sender).Left;
                    int y1 = e.Y+((Button)sender).Top;
                    Form1_MouseMove(this, new MouseEventArgs(e.Button,e.Clicks,x1,y1,e.Delta));
                };

                boton.MouseDown += Button_MouseDown;
                boton.MouseUp += Button_MouseUp;

                this.Controls.Add(boton);

                x += ancho + 10;
                if (i % 5 == 0)
                {
                    y += alto + 10;
                    x = 80;
                }
            }
            this.button1.MouseMove += (sender, e) =>
            {

                int x1 = e.X + ((Button)sender).Left;
                int y1 = e.Y + ((Button)sender).Top;
                Form1_MouseMove(this, new MouseEventArgs(e.Button, e.Clicks, x1, y1, e.Delta));
            };
            this.button2.MouseMove += (sender, e) =>
            {

                int x1 = e.X + ((Button)sender).Left;
                int y1 = e.Y + ((Button)sender).Top;
                Form1_MouseMove(this, new MouseEventArgs(e.Button, e.Clicks, x1, y1, e.Delta));
            };


        }


        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                boton.ForeColor = Color.Red;
                Debug.WriteLine($"Pulsado: {boton.Text}");
            }
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
                boton.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿seguro que desea salir?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (resultado==DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}
