using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nuevosComponentes
{
    public partial class ControlMultimedia : UserControl
    {
        [Category("eventosCarlos")]
        [Description("Se ejecuta al jacer click en el boton")]

        public event EventHandler PlayClick; // creacion del evento

        [Category("eventosCarlos")]
        [Description("lleva el control del tiempo")]

        public event EventHandler DesbordaTiempo;

        private int Minutos;
        private int Segundos;
        public int minutos
        {
            get { return Minutos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                if (value > 59)
                {
                    value = 0;

                }
                Minutos = value;
                ControlMultimedia_Load(null, null);
            }
        }

        public int segundos
        {
            get { return Segundos; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                Segundos = value;
                if (value > 59)
                {
                    Segundos = value % 60;
                    if (Segundos == 0 && value != 0)
                    {
                        DesbordaTiempo?.Invoke(this, EventArgs.Empty);
                    }

                }
                ControlMultimedia_Load(null, null);

            }

        }


        public ControlMultimedia()
        {
            InitializeComponent();

        }

        public ControlMultimedia(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Pause")
            {
                button1.Text = "Play";
            }
            else
            {
                button1.Text = "Pause";
            }
            PlayClick?.Invoke(this, e); //lanza el evento 
        }

        private void ControlMultimedia_Load(object sender, EventArgs e)
        {
            label1.Text = ($"{minutos:d2}:{segundos:d2}");
        }
    }
}
