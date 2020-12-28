using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Zerouri_la_final
    {
        /// <summary>
        ///  Interschimbati elementele unui vector in asa fel incat la final toate
        ///  valorile egale cu zero sa ajunga la sfarsit. 
        ///  (nu se vor folosi vectori suplimentari - operatia se va
        ///  realiza inplace cu un
        ///  algoritm eficient - se va face o singura parcugere a vectorului).
        /// </summary>
        /// 
        /// <example> Dutch national flag problem : 
        /// https://en.wikipedia.org/wiki/Dutch_national_flag_problem#:~:text=The%20Dutch%20national%20flag%20problem,%3A%20red%2C%20white%20and%20blue</example>

        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] v = { 0, 4, 0, 78, 1, 0, 12, 0, 4, 0, 0,9 };
            for (int q = 0; q < v.Length; q++)
                Console.Write($"{v[q]} ");
            Console.WriteLine();
            int k = 0;
            for(int i=0;i<v.Length;i++)
            {
                if(v[i]==0)
                {
                    int aux = v[i];
                    v[i] = v[k];
                    v[k] = aux;
                    k++;
                }
            }
            

           
            for (int q = v.Length-1; q >=0 ; q--)
                Console.Write($"{v[q]} ");

        }
    }
}
