namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {// boton traspasar
            if (radioButton3.Checked)
            {//1>>>2
                listBox2.Items.Add(listBox1.SelectedItems);
            }
            else if (radioButton4.Checked)
            {//1<<<2

            }
            else
            {
                MessageBox.Show("debes seleccionar una de las dos opciones", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//boton añadir
            string texto = textBox.Text.Trim();
            if (texto != "" && !listBox1.Items.Contains(texto))
            {
                listBox1.Items.Add(texto);
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "eliminar de Lista 2";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Text = "eliminar de Lista 1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button3.Text = "Traspaso 1 <<< 2";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//boton borrar 

            if (radioButton2.Checked)
            {
                for (int x = (listBox1.SelectedIndex - 1); x >= 0; x--)
                {
                    listBox1.Items.RemoveAt(x);
                }
            }
            else if (radioButton1.Checked)
            {
                if (radioButton1.Checked)
                {
                    for (int i = listBox1.Items.Count - 1; i >= 0; i--)
                    {
                        if (i != listBox1.SelectedIndex)
                            listBox1.Items.RemoveAt(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("debes seleccionar una de las dos opciones", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button3.Text = "Traspaso 1 >>> 2";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Text = "Quitar";
            button2.Text = "Traspasar";
            
        }
    }
}
