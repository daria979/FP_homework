using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class abc_Crescator
    {
        /// <summary>
        /// Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti trei numere diferite intreg de la tastatura: ");
            int a, b, c;

            try
            {
                Console.Write("a: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("b: ");
                if (!int.TryParse(Console.ReadLine(), out b))
                    throw new Exception("Nu ati introdus un numar !");
                Console.Write("c: ");
                if (!int.TryParse(Console.ReadLine(), out c))
                    throw new Exception("Nu ati introdus un numar !");
                if(a==b && b==c)
                    throw new Exception("Nu ati introdus 3 numere distincte!");

                if (a<b && a<c)
                {
                    if (b < c)
                        Console.WriteLine($"Ordinea numerelor este: {a} {b} {c}");
                    else
                        Console.WriteLine($"Ordinea numerelor este: {a} {c} {b}");
                }
                if (b < a && b < c)
                {
                    if (a < c)
                        Console.WriteLine($"Ordinea numerelor este: {b} {a} {c}");
                    else
                        Console.WriteLine($"Ordinea numerelor este: {b} {c} {a}");
                }
                if (c < a && c < b)
                {
                    if (a < b)
                        Console.WriteLine($"Ordinea numerelor este: {c} {a} {b}");
                    else
                        Console.WriteLine($"Ordinea numerelor este: {c} {b} {a}");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
