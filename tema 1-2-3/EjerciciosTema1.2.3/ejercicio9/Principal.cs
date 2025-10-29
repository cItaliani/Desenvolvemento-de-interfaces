using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio9
{
    public class Principal
    {

        public static void Main()//TODO control de exc
        {
            int eleccion;
            bool flag;
            Dictionary<string, Ordenador> redOrdenadores = new Dictionary<string, Ordenador>();
            do
            {

                do
                {
                    
                Console.WriteLine("escoge entre las siguientes opciones:");
                    Console.WriteLine("[1] agrega un host");
                    Console.WriteLine("[2] muestra un host. por clave.");
                    Console.WriteLine("[3] muestra todos los host");
                    Console.WriteLine("[4] elimina un host. por clave.");
                    Console.WriteLine("[0] SALIR");
                    flag= Int32.TryParse(Console.ReadLine(), out eleccion)&&(eleccion >=0 && eleccion <= 4);
                }
                while (!flag);

                
                    switch (eleccion)
                {
                    case 1:
                        agregarHost(redOrdenadores);
                        break;
                    case 2:
                        mostrarUno(redOrdenadores);
                        break;
                    case 3:
                        mostrarIPs(redOrdenadores);
                        break;
                    case 4:
                        eliminarHost(redOrdenadores);
                        break;
                    case 0:
                        Console.WriteLine("saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("introduce una opción válida");
                        break;
                    }
                }
                while (eleccion != 0) ;
            }

        public static void agregarHost(Dictionary<string, Ordenador> redOrdenadores)
        {
            string ipUsuario;
            bool flag = false;
            int ramUsuario = 0;
            Console.WriteLine("escribe la IP:");
            ipUsuario = Console.ReadLine();
            flag = Ordenador.compruebaIP(ipUsuario);
            do
            {
                Console.WriteLine("dime el tamaño de la RAM:");
                Int32.TryParse(Console.ReadLine(), out int ram);
                if (ram > 0)
                {
                    flag = true;
                    ramUsuario = ram;

                }
            }
            while (!flag);

            //if (flag)
            {
                if (!redOrdenadores.ContainsKey(ipUsuario))
                {

                    Ordenador nuevoPC = new Ordenador("ordenador " + redOrdenadores.Count(), ramUsuario);
                    redOrdenadores.Add(ipUsuario, nuevoPC);
                }
                else
                {
                    Console.WriteLine($"la {ipUsuario} ya se encunetra registrada en el sistema. Dato NO añadido");
                }

            }
        }

        public static void mostrarUno(Dictionary<string, Ordenador> redOrdenadores)
        {
            string ipConsulta;
            bool flag = false;

            do
            {
                Console.WriteLine("escribe la IP que quieres consultar:");
                ipConsulta = Console.ReadLine();
                flag = Ordenador.compruebaIP(ipConsulta);
            }
            while (!flag);



            //foreach (var host in redOrdenadores)//TODO sin bucle indexa con []
            //{
            //    if (host.Key == ipConsulta)
            //    {
            //        Console.WriteLine($"host: {host.Value.Nombre} | memoria RAM: {host.Value.MemoriaRAM}GB");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"no se encuentra informacion con {ipConsulta} ");
            //    }
            //}
            if (redOrdenadores.ContainsKey(ipConsulta))
            {
                Console.WriteLine(redOrdenadores[ipConsulta]);
            }
            else
            {
                Console.WriteLine($"no se encuentra informacion con {ipConsulta} ");
            }
        }

        //public static void mostarTodos(Dictionary<string, Ordenador> redOrdenadores)//TODO mostrar solo ips
        //{
        //    int i = 1;
        //    foreach (var host in redOrdenadores)
        //    {
        //        Console.WriteLine($"{i}. ordenador: {host.Key} | nombre: {host.Value.Nombre} |  memoria RAM: {host.Value.MemoriaRAM}GB");
        //        i++;
        //    }
        //} esta funcione esta comentada por que en el switch está cambiada por mostrarIPs

        public static void mostrarIPs(Dictionary<string, Ordenador> redOrdernadores)
        {
            foreach (var host in redOrdernadores.Keys)
            {
                Console.WriteLine(host);
            }
        }

        public static void eliminarHost(Dictionary<string, Ordenador> redOrdenadores)
        {
            string ipConsulta;
            bool flag;
            do
            {
                Console.WriteLine("escribe la IP que quieres borrar:");
                ipConsulta = Console.ReadLine();
                flag = Ordenador.compruebaIP(ipConsulta);
            }
            while (!flag);

            foreach (var host in redOrdenadores)
            {
                if (host.Key == ipConsulta)
                {
                    redOrdenadores.Remove(ipConsulta);
                }
            }

            //if (redOrdenadores.ContainsKey(ipConsulta))
            //{
            //    redOrdenadores.Remove(ipConsulta);
            //} codigo Juan Otero, hace lo mismo que lo mio de arriba 




        }
    }
}
