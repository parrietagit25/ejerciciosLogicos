using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dobledelprimeroycuadradodelsegundomaspromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            Console.WriteLine((2 * x) + (Math.Pow(y, 2)));
            Console.WriteLine((Math.Pow(x, 3) + Math.Pow(y, 3)) / 2);
            Console.ReadKey();
        }
    }
}
