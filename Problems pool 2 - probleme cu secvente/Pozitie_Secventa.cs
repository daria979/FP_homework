using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Pozitie_Secventa
    {
        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. 
        /// Daca numarul nu se afla in secventa raspunsul va fi -1.
        /// </summary>
        /// <param name="args"></param>
        /// 
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

                int poz = 0;
                int nr_aparitii = 0;
                bool ok = false;
                int a = rnd.Next(100);
                Console.WriteLine($"Numarul cautat in secventa este: {a}");
                Console.WriteLine("Secventa data este: ");
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(100);
                    Console.Write($"{x} ");
                    if (a==x)

                    {
                        poz = i;
                        ok = true;
                        nr_aparitii++;
                        //break;
                    }
                    if (ok == false)
                        poz = -1;
                }


                Console.WriteLine();
                   
                if(ok)
                {
                    if(nr_aparitii==0)
                            Console.WriteLine($"Numarul cautat {a} se afla pe poztia {poz} in secventa data.");
                    else
                        if(nr_aparitii>1)
                        {
                        Console.WriteLine($"Prima aparitie a numarulului cautat {a} se afla pe poztia {poz} in secventa data .");
                        Console.WriteLine($"Numarul cautat {a} mai apare in secventa data de inca {nr_aparitii} ori .");
                        }      
                }
                else
                    Console.WriteLine($"{poz} : Numarul cautat {a} NU exista in secventa data .");
              



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
