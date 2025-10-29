using System.Diagnostics;
using System.Linq.Expressions;

namespace ejercicio4
{
    internal class Program
    {
        public static int compruebaRango()
        {
            int usuario = 0;
            do
            {
                Console.WriteLine("dime el numero que quieres usar, tiene que estar entre 0 y 10.000: ");
                usuario = Int32.Parse(Console.ReadLine());
                if (!(usuario > 0 && usuario < 10000))
                {
                    Console.WriteLine($"el numero {usuario} esta fuera del rango solicitado");
                }

            }
            while (!(usuario > 0 && usuario < 10000));
                return usuario;
        }


        public static bool compruebaBisiesto(int year)
        {
            //bool pass = false;
            //if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            //{
            //    pass = true;
            //}
            //return pass;

            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        public static int? sumaRango(int numA, int numB)
        {
            int? resultado = null;
            if (numA < numB)
            {
                resultado = 0;
                for (int i = numA; i <= numB; i++)
                {
                    resultado += i;
                }


            }
            return resultado; 
        }
        static void Main(string[] args)
        {
            int usuario = 0;

            do
            {
                bool flag = false;
                Console.WriteLine("Escoge una de las siguientes opciones: ");
                Console.WriteLine("[1] año bisiesto");
                Console.WriteLine("[2] suma rango de números");
                Console.WriteLine("[3] realiza las opciones anteriores");
                Console.WriteLine("[4] Salir del programa");
                usuario = Int32.Parse(Console.ReadLine());

                switch (usuario)
                {
                    case 1:

                      int year = compruebaRango();
                      bool yearValidate= compruebaBisiesto(year);

                        if (yearValidate)
                        {
                            Console.WriteLine("el año {0} es bisiesto", year);
                        }
                        else
                        {
                            Console.WriteLine($"el año {year}  no es bisiesto");
                        }

                        if (flag)
                        {
                            goto case 2;
                        }
                        break;


                    case 2:
                        int numA = 0;//TODO funcion de peticion de datos
                        int numB = 0;
                        int? total = 0;
                        numA = compruebaRango();
                        numB = compruebaRango();

                        total = sumaRango(numA, numB);

                        if (total == null)
                        {
                            Console.WriteLine("el resultado de tu operacion es: NULL");
                        }
                        else
                        {
                            Console.WriteLine("el resultado de tu operacion es: " + total);
                        }
                        break;

                    case 3:
                        flag = true;
                        goto case 1;


                    case 4:
                        Console.WriteLine("Cerrando programa...");
                        break;
                }

            }
            while (usuario != 4);

        }
    }
}
