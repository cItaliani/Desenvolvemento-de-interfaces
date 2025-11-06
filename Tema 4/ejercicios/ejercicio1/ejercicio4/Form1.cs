namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//boton añadir
            string texto = textBox.Text.Trim();
            if (texto != "" && !listBox1.Items.Contains(texto))
            {
                Console.WriteLine("funciona");
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
            button3.Text = "Traspaso 2 -> 1";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//boton borrar 

            if (radioButton1.Checked)
            {
                foreach (var item in listBox1.Items)
                {
                listBox1.Items.Remove(listBox1.SelectedItems);  
                }
            }
            if (radioButton2.Checked)
            {
                if (radioButton2.Checked)
                {
                    
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button3.Text = "Traspaso 1 -> 2";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Count();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
