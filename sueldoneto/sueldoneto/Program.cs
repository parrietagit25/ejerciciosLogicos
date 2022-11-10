using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sueldoneto
{
    class Program
    {
        static void Main(string[] args)
        {
            int sueldo;

            sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Salario Bruto: " + sueldo);
            Console.WriteLine("Descuento ARS 3%: " +  ((sueldo * 3)/100));
            Console.WriteLine("Descuento AFP 4%: " + ((sueldo * 4) / 100));
            Console.WriteLine("Renta 10%: " + ((sueldo * 10) / 100));
            Console.WriteLine("Salario Neto: " + (sueldo - ((sueldo * 10) / 100) + ((sueldo * 4) / 100)) + ((sueldo * 3) / 100));
            Console.ReadKey();
        }
    }
}
