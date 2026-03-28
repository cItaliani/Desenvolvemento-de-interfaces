using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio1
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion==nuevosComponentes.LabelTextBox.EPosicion.DERECHA)
            {
            labelTextBox1.Posicion = nuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;      
            }
            else
            {
                labelTextBox1.Posicion = nuevosComponentes.LabelTextBox.EPosicion.DERECHA;
            }
        }
    }
}
