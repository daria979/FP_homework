using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
namespace Problems_pool_3___probleme_cu_tablouri
{
    class Ciurul_lui_Eratostene
    {
        /// <summary>
        ///  Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n
        ///  (ciurul lui Eratostene).
        /// </summary>
        /// <param name="args"></param>
        /// 
        
        static void Main(string[] args)
        {
            //Se scrie șirul numerelor naturale de la 2 până la n, ordonate crescător, intr-0 lista.
            List<int> Sir = new List<int>();
           
            int n;
            Console.Write("n: ");
            n = int.Parse(Console.ReadLine());

            //introducerea elementelor unei liste ----> nume_lista.Add(valoare);
            for(int i=2;i<=n;i++)
                Sir.Add(i);

            //afisarea elementelor unei liste
            /*foreach (int numar in Sir)
            {
                Console.Write($"{numar} ");
            }
            Console.WriteLine();*/


            int[] v = new int[n];int k = 0; 

            //Se taie din acest șir toți multiplii numerelor prime, astfel:
            foreach (int numar in Sir.ToList()) //am adaugat .ToList() + cateva biblioteci noi
            {
                if (numar * 2 < 10) 
                {
                    for (int multiplu = 2; numar * multiplu <= n; multiplu++)
                        Sir.Remove(numar * multiplu);

                    //vom retine doar ultimul subsir de rezultate(in care sunt doar cele prime)
                    k = 0;
                    foreach (int nr_ramas in Sir)
                        v[k++] = nr_ramas;

                }
                else
                    break;
                 
            }
            Console.WriteLine();
            Console.WriteLine($"Sunt {k} numere prime din intervalul [2,{n}] iar ele sunt: ");
            for (int i = 0; i < k; i++)
                Console.Write(v[i]+" ");

            Console.WriteLine();
            Console.ReadKey();


        }
    }
}
