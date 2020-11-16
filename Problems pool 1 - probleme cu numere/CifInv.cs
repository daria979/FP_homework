using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class CifInv
    {
        /// <summary>
        /// Afisati in ordine inversa cifrele unui numar n.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastatura: ");
            int n;
            Console.Write("n: ");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write($"Numarul {n} in ordine inversa este: ");
                while(n>0)
                {
                    Console.Write(n % 10);
                    n = n / 10;
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
