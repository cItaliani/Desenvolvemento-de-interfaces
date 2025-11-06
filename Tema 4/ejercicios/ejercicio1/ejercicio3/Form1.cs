using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        string filePath = "";
        Int32 cuentaMinutos = 00;
        Int32 cuentaSegundos = 00;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
           // this.CancelButton += button2_Click();
        }

        private void timer1_Tick(object sender, EventArgs e)//TODOo archivos corruptos. Icono sec. 
        {
            cuentaSegundos++;
            if (cuentaSegundos == 60)
            {
                cuentaSegundos = 0;
                cuentaMinutos++;
            }
            string contador = cuentaMinutos.ToString("D2") + ":" + cuentaSegundos.ToString("D2");
            string titulo = "Visor de imágenes";
            this.Text = titulo + " " + contador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "Imágenes (*.jpg;*.png) |*.jpg;*.png|todos los archivos (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;

                Form formulario2 = new Form();
                formulario2.Text = Path.GetFileName(filePath);
                try {
                formulario2.Icon = new Icon("icono.ico");
                }
                catch (System.IO.FileNotFoundException)
                {
                    Console.Write("no se ha cargado el icono");
                };
                formulario2.StartPosition = FormStartPosition.CenterScreen;
                formulario2.ClientSize = new Size(800, 600);

                PictureBox pizarra = new PictureBox();
                pizarra.Dock = DockStyle.Fill;
                pizarra.Image = Image.FromFile(filePath);
                pizarra.SizeMode = PictureBoxSizeMode.StretchImage;

                ContextMenuStrip menu = new ContextMenuStrip(); // s -> 
                menu.Items.Add("ajustar al PictureBox", null, (sender, e) =>
                {
                    pizarra.SizeMode = PictureBoxSizeMode.StretchImage;
                });
                menu.Items.Add("mantener proporciones", null, (sender, e) =>
                {
                    pizarra.SizeMode = PictureBoxSizeMode.Zoom;
                });

                pizarra.ContextMenuStrip = menu;

                formulario2.Controls.Add(pizarra);

                if (checkBox1.Checked)
                {
                    formulario2.ShowDialog();
                    //showDialog es modal
                }
                else
                {
                    formulario2.Show();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.ForeColor = Color.Red;
            }
            else
            {
                checkBox1.ForeColor = Color.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("esto cerrará el programa por completo", "alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
