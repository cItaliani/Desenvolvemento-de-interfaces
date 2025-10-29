namespace Hilos1
{
    internal class Program
    {
        static bool running = true; // Booleana compartida para controlar los bucles
        static void Main(string[] args)
        {
            Thread thread = new Thread(writeDown);
            thread.Start();
            // writeUp
            int i = 1;
            while (running)
            {
                Console.SetCursorPosition(1, 1);
                Console.Write("{0,4}", i);
                i++;
                if (i >= 1000)
                {
                    running = false;
                }
            }
            Console.ReadKey();
        }
        static void writeDown()
        {
            int i = 1;
            while (running)
            {
                Console.SetCursorPosition(1, 20);
                Console.Write("{0,4}", i);
                i++;
                if (i >= 1000)
                {
                    running = false;
                }
            }
        }
    }
}
