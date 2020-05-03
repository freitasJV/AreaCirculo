using System;
using System.Globalization;

namespace AreaCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double raio, area, pi = 3.14159;

                Console.WriteLine("Digite o valor do raio do círculo:");
                raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (raio < 0)
                {
                    Console.WriteLine("Valor inválido");
                }
                else
                {
                    area = pi * Math.Pow(raio, 2);

                    Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}