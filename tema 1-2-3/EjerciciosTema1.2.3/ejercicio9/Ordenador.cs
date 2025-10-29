using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    public class Ordenador
    {
        public string Nombre { get; set; }
        public int MemoriaRAM { get; set; }

        public Ordenador(string nombre, int memoriaRAM)
        {
            this.Nombre = nombre;
            this.MemoriaRAM = memoriaRAM;
        }

        public static bool compruebaIP(string ipUsuario)
        {

            String[] ip = ipUsuario.Split(".");
            if (ip.Length == 4)
            {
                foreach (var item in ip)
                {
                    if (!int.TryParse(item, out int numero))
                    {
                        return false;
                    }
                    if (numero < 0 || numero > 255)//usar byte.tryparse 
                    {                             // usar try parse
                        return false;
                    }
                }
                return true;

            }
            return false;
        }
    }
}
