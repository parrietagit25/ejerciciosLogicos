using System;

namespace prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            float prestamo = 10000;

            Console.WriteLine("El plazo a 2 a;os es: " + ((prestamo * 27)/100) * 2);
        }
    }
}
