using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    class Stergere_repetari
    {
        /// <summary>
        /// . Modificati un vector prin eliminarea elementelor care se repeta,
        ///fara a folosi un alt vector.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          
            int[] v = { 4,1,9,3,2,7,4,4,3,1,3,9,8};
            int n = v.Length;
            int y = v[n - 1];
            bool ok = true;
            //Console.Write(n);
            for(int i=0;i<n-1;i++)
            {
                for(int j=1;j<n;j++)
                {
                    if (v[i] == v[j])
                    {
                        n--;
                        for (int q=0;q<n;q++)
                        {
                            if (i <= j)
                                v[i] = v[i];
                            else
                            {
                                v[j-1] = v[j];
                              
                            }
                            
                        }
                    }
                    //pt verificarea ultimului, care se "pierde"
                    //ot ca nu are cu cine sa fie comparat
                    if (v[j] == y)
                        ok = false;
                } 
                
            }
            if(ok==true)
            {
                for (int q = 0; q < n; q++)
                    Console.Write(v[q] + " ");
                Console.Write(y);
            }
            else
                for (int q = 0; q < n; q++)
                    Console.Write(v[q] + " ");


        }
    }
}
