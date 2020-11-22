using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Secv_Crescatoare
    {
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Sa se determine daca numerele din secventa sunt in ordine crescatoare.
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

                bool ok = true;
                int x = rnd.Next(31);

                Console.WriteLine("Secventa data este: ");
                Console.Write($"{x} ");
                for(int i=0;i<n;i++)
                {
                    int y = rnd.Next(31);
                    Console.Write($"{y} ");

                    if (!(x <= y))
                        ok = false;

                    x = y;
                    
                }

                if (ok)
                    Console.WriteLine("Secventa data are numerele in oridne CRESCATOARE.");
                else
                    Console.WriteLine("Secventa data NU are numerele in oridne CRESCATOARE.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
