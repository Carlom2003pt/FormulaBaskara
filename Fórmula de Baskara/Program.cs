using System;

namespace Fórmula_de_Baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double exemploMais, delta, exemploMenos;
            Console.WriteLine("Digite o primeiro número!");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Digite o segundo número");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite o terceiro número");

            c = double.Parse(Console.ReadLine());

            Console.WriteLine();

            delta = b * b - 4 * a * c;
            



            if ((a == 0) || (delta < 0))
            {
                Console.WriteLine("Impossivel calcular");

            }
            else
            {
                exemploMais = (-b + Math.Sqrt(delta)) / (2 * a);
                exemploMenos = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("X1 = " + exemploMais);
                Console.WriteLine("X2 = " + exemploMenos);
            }



        }
    }
}
