using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Nnr_Fibonacci
    {
        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: 
        /// f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        
        static int Fibo(int n) //metoda recursiva
        {
            if (n <= 1)
                return n;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar de la tastatura: ");
            int n;

            try
            {
                Console.Write("n: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                    throw new Exception("Nu ati introdus un numar !");

                Console.Write($"Al {n}-lea numar din sirul lui Fibonacci este: ");
                Console.Write(Fibo(n));

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
