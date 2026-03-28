using System.Drawing;

namespace ejercicio2tema5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso3 = new nuevosComponentes.EtiquetaAviso();
            this.etiquetaAviso2 = new nuevosComponentes.EtiquetaAviso();
            this.etiquetaAviso1 = new nuevosComponentes.EtiquetaAviso();
            this.etiquetaAviso4 = new nuevosComponentes.EtiquetaAviso();
            this.etiquetaAviso5 = new nuevosComponentes.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // etiquetaAviso3
            // 
            this.etiquetaAviso3.ColorA = System.Drawing.Color.Yellow;
            this.etiquetaAviso3.ColorB = System.Drawing.Color.Purple;
            this.etiquetaAviso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso3.ImagenMarca = global::ejercicio2tema5.Properties.Resources.atlas;
            this.etiquetaAviso3.IsGradiente = true;
            this.etiquetaAviso3.Location = new System.Drawing.Point(63, 234);
            this.etiquetaAviso3.Marca = nuevosComponentes.EMarca.Imagen;
            this.etiquetaAviso3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etiquetaAviso3.Name = "etiquetaAviso3";
            this.etiquetaAviso3.Size = new System.Drawing.Size(502, 75);
            this.etiquetaAviso3.TabIndex = 2;
            this.etiquetaAviso3.Text = "etiquetaAviso3";
            this.etiquetaAviso3.Click += new System.EventHandler(this.etiquetaAviso3_Click);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.ColorA = System.Drawing.Color.Yellow;
            this.etiquetaAviso2.ColorB = System.Drawing.Color.Purple;
            this.etiquetaAviso2.ImagenMarca = null;
            this.etiquetaAviso2.IsGradiente = true;
            this.etiquetaAviso2.Location = new System.Drawing.Point(63, 57);
            this.etiquetaAviso2.Marca = nuevosComponentes.EMarca.Cruz;
            this.etiquetaAviso2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(113, 18);
            this.etiquetaAviso2.TabIndex = 1;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorA = System.Drawing.Color.Yellow;
            this.etiquetaAviso1.ColorB = System.Drawing.Color.Purple;
            this.etiquetaAviso1.ImagenMarca = null;
            this.etiquetaAviso1.IsGradiente = true;
            this.etiquetaAviso1.Location = new System.Drawing.Point(63, 15);
            this.etiquetaAviso1.Marca = nuevosComponentes.EMarca.Nada;
            this.etiquetaAviso1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(92, 16);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // etiquetaAviso4
            // 
            this.etiquetaAviso4.ColorA = System.Drawing.Color.Yellow;
            this.etiquetaAviso4.ColorB = System.Drawing.Color.Purple;
            this.etiquetaAviso4.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("etiquetaAviso4.ImagenMarca")));
            this.etiquetaAviso4.IsGradiente = true;
            this.etiquetaAviso4.Location = new System.Drawing.Point(90, 133);
            this.etiquetaAviso4.Marca = nuevosComponentes.EMarca.Imagen;
            this.etiquetaAviso4.Margin = new System.Windows.Forms.Padding(4);
            this.etiquetaAviso4.Name = "etiquetaAviso4";
            this.etiquetaAviso4.Size = new System.Drawing.Size(147, 56);
            this.etiquetaAviso4.TabIndex = 3;
            this.etiquetaAviso4.Text = "etiquetaAviso4";
            // 
            // etiquetaAviso5
            // 
            this.etiquetaAviso5.ColorA = System.Drawing.Color.Yellow;
            this.etiquetaAviso5.ColorB = System.Drawing.Color.Purple;
            this.etiquetaAviso5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaAviso5.ImagenMarca = global::ejercicio2tema5.Properties.Resources.atlas;
            this.etiquetaAviso5.IsGradiente = true;
            this.etiquetaAviso5.Location = new System.Drawing.Point(63, 95);
            this.etiquetaAviso5.Marca = nuevosComponentes.EMarca.Circulo;
            this.etiquetaAviso5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.etiquetaAviso5.Name = "etiquetaAviso5";
            this.etiquetaAviso5.Size = new System.Drawing.Size(534, 115);
            this.etiquetaAviso5.TabIndex = 3;
            this.etiquetaAviso5.Text = "etiquetaAviso5";
            this.etiquetaAviso5.Click += new System.EventHandler(this.etiquetaAviso5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 395);
            this.Controls.Add(this.etiquetaAviso5);
            this.Controls.Add(this.etiquetaAviso3);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.etiquetaAviso1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ejercicio 2 tema 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private nuevosComponentes.EtiquetaAviso etiquetaAviso1;
        private nuevosComponentes.EtiquetaAviso etiquetaAviso2;
        private nuevosComponentes.EtiquetaAviso etiquetaAviso3;
        private nuevosComponentes.EtiquetaAviso etiquetaAviso4;
        private nuevosComponentes.EtiquetaAviso etiquetaAviso5;
    }
}

