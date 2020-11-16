using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class Palindrom
    {
        /// <summary>
        /// Determianti daca un numar n este palindrom. 
        /// (un numar este palindrom daca citit invers obtinem un numar egal cu el, 
        /// de ex. 121 sau 12321.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void is_palindrom(int n)
        {
            int m = n;
            int p = 0;

            while (n > 0)
            {
                p = p * 10 + n % 10;
                n = n / 10;
            }
            if (p == m)
                Console.WriteLine($"Numarul {m} este palindrom.");
            else
                Console.WriteLine($"Numarul {m} NU este palindrom.");
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

                is_palindrom(n);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
