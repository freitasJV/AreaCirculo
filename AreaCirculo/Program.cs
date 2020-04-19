using System;
using System.Globalization;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio do círculo:");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}