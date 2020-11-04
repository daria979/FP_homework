using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Ecuatie_gradul_II
    {
        /// <summary>
        /// Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, 
        /// unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double a, b, c, x1, x2, delta;

            Console.Write("Introduceti un numar a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Introduceti un numar c: ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("Ecuatia de gradul II formata este: " + Math.Sign(a) * Math.Abs(a) + "x^2 " + Math.Sign(b) * Math.Abs(b) + "x " + Math.Sign(c) * Math.Abs(c));
            Console.WriteLine();

            delta = Math.Sqrt(b * b - 4 * a * c); //sqrt accepta doar tipul de data double

            x1 = (-b - delta) / (2 * a * c);
            x2 = (-b + delta) / (2 * a * c);
            x1 = Math.Round(x1, 2);
            x2 = Math.Round(x2, 2);

            if (delta > 0)
            {
                Console.WriteLine($"Solutiile x1 si x2 apartin lui R si sunt diferite: x1 = {x1} si x2 = {x2}");
                Console.WriteLine();
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine($"Solutiile x1 si x2 NU apartin lui R, ci lui C, deci, nu pot fi determinate pe multimea R");
                    Console.WriteLine();
                }
                else
                {
                    if (delta == 0)
                    {
                        Console.WriteLine($"Solutiile x1 si x2 apartin lui R si sunt egale: x1 = {x1} si x2 = {x2}");
                        Console.WriteLine();
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
