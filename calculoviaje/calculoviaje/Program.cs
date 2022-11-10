using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace calculoviaje
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometros;

            Console.WriteLine("Ingrese la cantidad de kilometros: ");

            kilometros = int.Parse(Console.ReadLine());

            Console.WriteLine("El total a pagar es: " + (kilometros * 10.5));
        }
    }
}
