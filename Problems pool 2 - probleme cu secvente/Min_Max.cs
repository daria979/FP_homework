using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Min_Max
    {
        /// <summary>
        /// Se da o secventa de n numere. 
        /// Sa se determine cea mai mare si cea mai mica valoare din secventa.
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

                int Min = rnd.Next(101);
                int Max = rnd.Next(101);


                Console.WriteLine("Secventa data este: ");
                for(int i=0;i<n;i++)
                {
                    int x = rnd.Next(101);
                    Console.Write($"{x} ");
                    if (x < Min)
                        Min = x;
                    if (x > Max)
                        Max = x;

                }

                /*int  n,x=0, ap=1, app=1;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            
            int max=0;
            int min=0;
            for (int i = 1; i <= n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                    ap = 1;
                }
                else

                    if (x == max)
                    {
                    ap++;
                    }
                
                    if (x < min)
                    {
                        min = x;
                        app = 1;
                    }
                    else
                    if (x == min)
                    {
                        app++;
                    }
                
            }
            Console.WriteLine($"Maximul este {max} si apare de {ap} ori");
            Console.WriteLine($"Minimul este {min} si apare de {app} ori");
            Console.ReadKey();*/
                Console.WriteLine();
                Console.WriteLine($"Valoarea minima din secventa data este: {Min}.");
                Console.WriteLine($"Valoarea maxima din secventa data este: {Max}.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
