using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        
        public Form1()

        {

            
            InitializeComponent();
            this.CancelButton = button1;
            this.AcceptButton = button2;
            this.FormClosing += Form1_FormClosing;
            textBox1.Enter += enterColor;
            textBox2.Enter += enterColor;
            textBox3.Enter += enterColor;
            textBox4.Enter += enterImg;
            foreach (Control control in this.Controls)
            {
                if(control is Button bt)
                {
                    bt.MouseEnter += button_mouseEnter;
                    bt.MouseLeave += button_mouseLeave;
                }
            }

        }
        private void button_mouseEnter(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.BackColor = Color.LightBlue;
        }
        private void button_mouseLeave(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            boton.BackColor = Color.Empty;
        }
        private void enterColor(object sender, EventArgs e)
        {
            this.AcceptButton = button2;
        }

        private void enterImg(object sender, EventArgs e)
        {
            this.AcceptButton = button4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Realmente quieres cerrar?", "Confirmación", MessageBoxButtons.OKCancel);

            if (resultado == DialogResult.OK)
            {
                Close();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox tb)
                {
                    if ((string)tb.Tag=="color")
                    {
                        tb.Text = "0";
                    }else if ((string)tb.Tag=="imagen")
                    {
                        tb.Clear();
                    }
                }
            }
            this.BackColor = Color.Empty;
            pictureBox1.BackgroundImage = null;



            //textBox1.Text = "0";
            //textBox2.Text = "0";
            //textBox3.Text = "0";
            //textBox4.ResetText();
            //this.BackColor = Color.Empty;
            //pictureBox1.BackgroundImage = null;


        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (!validarRGB(textBox1.Text,textBox2.Text, textBox3.Text))
            {
                MessageBox.Show("algun dato es erronero, reviselo","Alerta",MessageBoxButtons.OK);
                return;
            }
            this.BackColor = Color.FromArgb(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            
        
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
           
            String ruta = textBox4.Text.Trim();
            if (string.IsNullOrWhiteSpace(ruta))
            {
                MessageBox.Show("revisa los datos introduicidos", "alerta", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (!File.Exists(ruta))
            {
                MessageBox.Show("revisa los datos introduicidos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Image img = new Bitmap(ruta);
                pictureBox1.BackgroundImage = img;
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }

            catch{
                MessageBox.Show("el archivo no es una imagen válida", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

   

        private bool validarRGB(params string[]valores)
        {
            foreach (string valor in valores)
            {
                if (!Int32.TryParse(valor,out int result)||result<0||result>255)
                {
                    return false;
                }
            }
                return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿seguro que desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

