namespace EjemploPOO
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Perro objPerro = new Perro();
            objPerro.raza = "Mastín";
            objPerro.nombre = "Laika";
            objPerro.setEdad(5);
            Console.WriteLine(objPerro.getEdad());
            Console.ReadLine();
        }
    }
}
