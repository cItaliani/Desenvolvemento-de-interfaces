namespace ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult usuario = MessageBox.Show("¿está seguro de la acción a realizar?", "CUADRO DE CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (usuario == DialogResult.Yes)
            {
                Text = textBox1.Text;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
