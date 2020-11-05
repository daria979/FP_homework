using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_4
{
    class Distanta_minima
    {
        static Random rnd = new Random();
        
        public class Point
        {
            public float x, y;
            public Point()
            {
                x=rnd.Next(1000);
                y=rnd.Next(1000);
            }
            public void view()
            {
                Console.WriteLine("(" + x + "," + y + ")");
            }
        }

        static float lungime(Point A, Point B)
        {
            return (float)Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
        }

        private void Main(string[] args) //static main
        {
            int n = 23;
            Point[] V = new Point[n];
            for (int i = 0; i < n; i++)
                V[i] = new Point();
            for (int i = 0; i < n; i++)
                V[i].view();
            for(int j=0;j<n-1;j++)
            {
                float lungmin = lungime(V[j], V[j + 1]);
                int indice = j + 1;
                for(int i1=j+1;i1<n;i1++)
                {
                    float l = lungime(V[j], V[i1]);
                    if(l<lungmin)
                    {
                        lungmin = 1;
                        indice = i1;
                    }
                }
                Point aux = V[j + 1];
                V[j + 1] = V[indice];
                V[indice] = aux;
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
                V[i].view();

            Console.ReadKey();
        }
    }
}
