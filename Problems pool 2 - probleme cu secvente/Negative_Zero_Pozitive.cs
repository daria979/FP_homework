using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Negative_Zero_Pozitive
    {
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
        /// </summary>
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                int nr_negative = 0;
                int nr_pozitive = 0;
                int nr_zerouri = 0;
                Console.WriteLine("Secventa de numere este: ");
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(-500,501);
                    Console.Write($"{x} ");
                    if (x == 0)
                        nr_zerouri++;
                    if (x > 0)
                        nr_pozitive++;
                    if (x < 0)
                        nr_negative++;

                }
                Console.WriteLine();
                Console.WriteLine("In secventa data sunt:");
                Console.WriteLine($"{nr_negative} numere negative;");
                Console.WriteLine($"{nr_pozitive} numere pozitive;");
                Console.WriteLine($"{nr_zerouri} zero-uri.");
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
