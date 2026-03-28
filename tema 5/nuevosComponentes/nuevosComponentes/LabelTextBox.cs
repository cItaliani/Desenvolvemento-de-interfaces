using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace nuevosComponentes
{
 
    public partial class LabelTextBox : UserControl
    {
        private Color colorSubrayado = Color.Blue;
        public Color ColorSubrayado
        {
            get => colorSubrayado;
            set => colorSubrayado = value;
        }

        private bool isUnderline = true;
        public bool IsUnderline
        {
            get => isUnderline;
            set => isUnderline = value;
        }

        public char PswChr
        {
            get => txt.PasswordChar;
            set => txt.PasswordChar = value;
        }

        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }

        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
        }

        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Nuevas")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    OnPosicionChanged(EventArgs.Empty);
                    Invalidate();
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
            }
            get
            {
                return lbl.Text;
            }
        }

        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        private int separacion = 0;
        [Category("Nuevas")]
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            get => separacion;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();

                if (separacion != value)
                {
                    separacion = value;
                    OnSeparacionChanged(EventArgs.Empty);
                    Invalidate();
                }
            }
        }

        void recolocar()
        {
            int ancho = txt.Width;

            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    lbl.Location = new Point(0, 0);
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    this.Width = ancho + lbl.Width + separacion;
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    txt.Location = new Point(0, 0);
                    this.Width = ancho + lbl.Width + separacion;
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            if (IsUnderline)
            {
                Pen lapiz = new Pen(ColorSubrayado, 2);
                Graphics g = e.Graphics;
                g.DrawLine(lapiz, lbl.Left, lbl.Bottom, lbl.Right, lbl.Bottom);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

 
        [Category("Nuevos Eventos")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }

    
        [Category("Nuevos Eventos")]
        [Description("Se lanza cuando la propiedad Separacion cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
            if (SeparacionChanged != null)
            {
                SeparacionChanged(this, e);
            }
        }

    
        [Category("Nuevos Eventos")]
        [Description("Se lanza cuando cambia el texto del TextBox interno")]
        public event System.EventHandler TxtChanged;

        protected virtual void OnTxtChanged(EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, e);
            }
        }

        private void txt_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }

  
        private void txt_TextChanged(object sender, EventArgs e)
        {
            OnTxtChanged(e);
        }

        private void LabelTextBox_Load(object sender, EventArgs e)
        {
        }
    }
}