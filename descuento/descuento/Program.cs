using System;

namespace descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            float costo_medicamento;

            Console.WriteLine("Ingrese el costo del medicamento: ");
            costo_medicamento = int.Parse(Console.ReadLine());
            Console.WriteLine("El descuento es: "+ (costo_medicamento * 35) / 100);
            Console.WriteLine("El monto a Pagar es: " + (costo_medicamento - (costo_medicamento * 35) / 100));
        }
    }
}
