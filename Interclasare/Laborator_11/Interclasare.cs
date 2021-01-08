using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Laborator_11
{
    class Interclasare
    {
        static int n1, n2;
        static int[] v1;
        static int[] v2;
        static int[] v3;

        static void load(string fileName)
        {
            TextReader Load = new StreamReader(fileName);
            string[] buffer;
            buffer = (Load.ReadLine()).Split(' ');
            n1 = int.Parse(buffer[0]);
            n2 = int.Parse(buffer[1]);
            v1 = new int[n1];
            v2 = new int[n2];

            buffer = (Load.ReadLine()).Split(' ');
            for (int i = 0; i < n1; i++)
                v1[i] = int.Parse(buffer[i]);

            buffer = (Load.ReadLine()).Split(' ');
            for (int i = n2 - 1; i >= 0; i--)
                v2[i] = int.Parse(buffer[i]);
        }

        static void solve_interclasare()
        {
            int[] tmp = new int[n1 + n2];
            int k1 = 0;
            int k2 = n2 - 1;
            int k3 = 0;

            while (k1 < n1 && k2 >= 0)
            {
                if (v1[k1] < v2[k2])
                {
                    if ((v1[k1] % 2) == 0)
                    {
                        tmp[k3] = v1[k1];
                        k3++;
                    }
                    k1++;
                }
                else
                {
                    if ((v2[k2] % 2) == 0)
                    {
                        tmp[k3] = v2[k2];
                        k3++;
                    }
                    k2--;
                }
            }
            while (k1 < n1)
            {
                if ((v1[k1]) % 2 == 0)
                {
                    tmp[k3] = v1[k1];
                    k3++;
                }
                k1++;
            }
            while (k2 >= 0)
            {
                if ((v2[k2]) % 2 == 0)
                {
                    tmp[k3] = v2[k2];
                    k3++;
                }
                k2--;

            }

            v3 = new int[k3];
            for (int i = 0; i < k3; i++)
                v3[i] = tmp[i];
        }

        static void view(int[] tov)
        {
            for (int i = 0; i < tov.Length; i++)
                Console.Write(tov[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            load(@"..\..\data.txt");
            view(v1);
            view(v2);
            solve_interclasare();
            view(v3);
            Console.ReadKey();
        }
    }
}
