# define bandera
namespace ejercicio5
{
    internal class Program
    {

        public static bool calculaFactorial(int numero, out int resultado)
        {
            bool flag = true;
            resultado = 1;
            if (numero < 0 || numero > 10)
            {
                flag = false;
            }
            else
            {
                // no coloco flag por que ya entra en true  
                int i;
                for (i = numero; i >= 1; i--)
                {
                    resultado = resultado * i;
                }

            }
            return flag;
        }

        public static void pintaAsterico(int cantidad = 10)
        {
            Random aleatorio = new Random();

            for (int i = 0; i < cantidad; i++)
            {
                Console.SetCursorPosition(aleatorio.Next(1, 10), aleatorio.Next(0, 20));
                Console.WriteLine("*");
            }

        }

        static void Main(string[] args)
        {
#if bandera 
            {

                int numero = 0;
                int resultado;

                Console.WriteLine("dime un numero: ");
                numero = Int32.Parse(Console.ReadLine());
                calculaFactorial(numero, out resultado);
                Console.WriteLine(resultado);
            }

#else

            pintaAsterico(20);
            Console.ReadLine();
#endif
        }

    }
}