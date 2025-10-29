namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre="";
            int edad=-1;
            double peso = -1.0;
            Console.WriteLine("¿Cual es tu nombre?");
            nombre=Console.ReadLine();
            Console.WriteLine("¿Cual es tu edad "+nombre+"?");
            edad = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ahora dime tu peso");
            peso = Double.Parse(Console.ReadLine());
            Console.WriteLine("Perfecto te llamas {0,12} tienes {1,4} año(s) y \n\t pesas {2,5:F1} kilos \n \"{0}\" \\{1}\\", nombre, edad, peso);
        }
    }
}
