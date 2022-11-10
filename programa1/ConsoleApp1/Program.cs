using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int NUM, AUX, DEC, UNI;
			string linea;

			Console.WriteLine("Ingrese un numero de 2 cifras: ");
			linea = Console.ReadLine();
			NUM = int.Parse(linea);
			DEC = NUM / 10;
			UNI = NUM % 10;
			AUX = (UNI * 10) + DEC;

			Console.WriteLine("Numero Invertido es: " + AUX);
			Console.WriteLine("Pulse una tecla:");
			Console.ReadLine();
		}
	}
}
