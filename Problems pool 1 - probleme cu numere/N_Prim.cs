using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class N_Prim
    {
        /// <summary>
        /// Test de primalitate: determinati daca un numar n este prim.
        /// </summary>
        /// <param name="args"></param>
        
        static bool is_prim(int n)
        {
            //timpul de executie este O(n)

            if (n % 2 == 0 && n>2) return false;
            if (n == 2) return true;
            if (n < 2) return false;
            if (n % 2 != 0)
                for (int i = 3; i * i <= n; i++)
                    if (n % i == 0)
                        return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar intreg de la tastatura");
            int n;
            Console.Write("n: ");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    throw new Exception("Nu ati introdus un numar !");
                }
                if (is_prim(n))
                    Console.WriteLine($"Numarl {n} este PRIM!");
                else
                    Console.WriteLine($"Numarl {n} NU este PRIM!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
