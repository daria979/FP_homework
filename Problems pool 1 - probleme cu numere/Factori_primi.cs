using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Factori_primi
    {
        /// <summary>
        /// Afisati descompunerea in factori primi ai unui numar n. 
        /// De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void factori_primi(int n)
        {
            int m = n;
            int d = 2;
            int nr = 0;
            int i = 0;
            while(n>1)
            {
                int p = 0;
                
                while (n%d==0)
                {
                    p++;
                    n = n / d;
                }
                if (p > 0)
                {
                    nr++;
                    // sa vedem cati factori primi sunt pentru a sti unde sa punem semul de inmultire 'x'  
                }
                  
                d++;
            }
            d = 2;
            while (m > 1)
            {
                int p = 0;

                while (m % d == 0)
                {
                    p++;
                    m = m / d;
                    i++;
                }
                if (p > 0 && i < nr)
                {
                    Console.Write($"{d}^{p} x ");
                }
                if(p > 0 && i==nr)
                {
                    Console.Write($"{d}^{p}.");
                }

                d++;
            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.WriteLine($"Descompunerea in factori primi a numarului {n} este: ");
                factori_primi(n);

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
