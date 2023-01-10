using System;

namespace Exercise2Hour
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("La hora es: {0}", time);
        }
    }
}
