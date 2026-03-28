using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nuevosComponentes
{
    public enum EMarca
    {//se recomienda definir los enum fuera de la clase 
        Nada,
        Cruz,
        Circulo,
        Imagen
    }

    public partial class EtiquetaAviso : Control
    {
        private bool isGradiente = true;
        private Image imagenMarca;
        private Rectangle zonaMarca;
        public Image ImagenMarca
        {
            get => imagenMarca;
            //set => imagenMarca = value;
            set { imagenMarca = value; Invalidate(); }
        }



        private Color colorA = Color.Yellow;

        public Color ColorA
        {
            get => colorA;
            //set => colorA = value;
            set { colorA = value; Invalidate(); }
        }
        private Color colorB = Color.Purple;
        public Color ColorB
        {
            get => colorB;
            //set => colorB = value;
            set { colorB = value; Invalidate(); }
        }

        public bool IsGradiente
        {
            get => isGradiente;
            //set => isGradiente = value;
            set { isGradiente = value; Invalidate(); }
        }

        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();//refresca 'pinta' marca cuando cambia
            }
            get
            {
                return marca;
            }
        }



        public event EventHandler clickEnMarca;
        protected virtual void OnclickEnMarca(EventArgs e)
        {
            if (clickEnMarca != null)
            {
                clickEnMarca(this, e);
            }

        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (marca!=EMarca.Nada&&zonaMarca.Contains(e.Location))
            {
                OnclickEnMarca(EventArgs.Empty);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            base.OnPaint(pe);
            Graphics g = pe.Graphics;
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            if (isGradiente)
            {
                using (LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, ColorA, ColorB, LinearGradientMode.ForwardDiagonal))
                {
                    g.FillRectangle(br, this.ClientRectangle);
                }
            }
            else
            {
                g.Clear(this.BackColor);
            }
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    zonaMarca = new Rectangle(grosor, grosor, h, h);
                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    zonaMarca = new Rectangle(grosor, grosor, h, h);
                    break;
                case EMarca.Imagen:
                    if (ImagenMarca != null)
                    {
                        zonaMarca = new Rectangle(5, 5, h, h);
                        g.DrawImage(ImagenMarca, zonaMarca);
                        offsetX = h + 8;
                    }
                    break;

            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
        }
    }
}
