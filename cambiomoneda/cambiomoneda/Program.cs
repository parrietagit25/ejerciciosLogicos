using System;

namespace cambiomoneda
{
    class Program
    {
        static void Main(string[] args)
        {

            float cantidad;

            Console.WriteLine("Ingrese la cantidad en RD$: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("El cambio a Dolares $ es :" + (cantidad * 20));
            Console.WriteLine("El cambio a Euros es :" + (cantidad * 24.35));
        }
    }
}
