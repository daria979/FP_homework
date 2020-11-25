using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class S_inverse
    {
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Se cere sa se caculeze suma inverselor acestor numere.
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

                double S = 0;
                double x;
               

                Console.WriteLine("Secventa este: ");
                for (int i=0;i<n;i++)
                {
                    x = rnd.Next(100);
                    Console.Write($"{x} ");
                    S = S + (1 / x);
                }
                Console.WriteLine();
                Console.WriteLine($"Suma inverselor numerelor din secventa data este: {S}");
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
