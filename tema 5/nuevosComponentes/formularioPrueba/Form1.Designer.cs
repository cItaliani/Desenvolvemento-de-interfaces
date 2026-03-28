namespace formularioPrueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTextBox1 = new nuevosComponentes.LabelTextBox();
            this.SuspendLayout();
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.ColorSubrayado = System.Drawing.Color.Blue;
            this.labelTextBox1.IsUnderline = true;
            this.labelTextBox1.Location = new System.Drawing.Point(30, 31);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = nuevosComponentes.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separacion = 60;
            this.labelTextBox1.Size = new System.Drawing.Size(195, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            this.labelTextBox1.PosicionChanged += new System.EventHandler(this.labelTextBox1_PosicionChanged);
            this.labelTextBox1.Load += new System.EventHandler(this.labelTextBox1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 104);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private nuevosComponentes.LabelTextBox labelTextBox1;
    }
}

