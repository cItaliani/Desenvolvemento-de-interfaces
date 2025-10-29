using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPOO
{
    internal class Perro
    {
        public string Raza { set;  get; }
        public string nombre;
        private int edad;
        public int Edad
        {
            set {
                this.edad = value;
            }
            get { 
                return this.edad;
            }


        }
        //public int getEdad()
        //{
        //    return edad;
        //}
        //public void setEdad(int edad)
        //{
        //    this.edad = edad;
        //}
        public Perro()
        {
            this.Edad=0;
            this.raza = "";
            this.nombre = "";
        }
    }
}
