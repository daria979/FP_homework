using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_1___probleme_cu_numere
{
    class cmmdc_cmmmc
    {
        /// <summary>
        /// Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. 
        /// Folositi algoritmul lui Euclid.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static int cmmdc(int n,int m)
        {
            //algoritmul lui Euclid: scaderi repetate
            while (m!=0)
                if (n > m)
                    n -= m;
                else
                    m -= n;
            
            return n;
        }

        static int cmmmc(int n,int m)
        {
            int x = n * m;
            int Rezultat= x / cmmdc(n, m);
           
            return Rezultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti doua intreg de la tastatura: ");
            int n, m;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write("m: ");
                if (!int.TryParse(Console.ReadLine(), out m))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write($"Cel mai mare divizor comun al numerelor {n} si {m} este: ");
                Console.Write(cmmdc(n, m));

                Console.WriteLine();

                Console.Write($"Cel mai mic multiplu comun al numerelor {n} si {m} este: ");
                Console.Write(cmmmc(n, m));

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
