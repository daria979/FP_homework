using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Laborator_11
{
    class Frecventa
    {
        public struct Data
        {
            public int count;
            public int pos;
        };

        static int n;
        static int[] v1;
        static int maxValue = int.MinValue;
        static void Load(string fileName)
        {
            TextReader load = new StreamReader(fileName);
            string[] buffer = load.ReadLine().Split(' ');
            n = int.Parse(buffer[0]);
            v1 = new int[n];
            buffer = (load.ReadLine()).Split(' ');
            for (int i = 0; i < n; i++)
            {
                v1[i] = int.Parse(buffer[i]);
                if (v1[i] > maxValue)
                    maxValue = v1[i];
            }
        }

        static void View(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static void frecventa(int[] a)
        {
            Data[] freq = new Data[maxValue + 1];

            for (int i = 0; i < freq.Length; i++)
                freq[i].pos = i;

            for (int i = 0; i < n; i++)
                freq[a[i]].count++;

            //MergeSort(freq, freq[0].count, freq[maxValue].count);
            Data aux;
            bool ok;
            do
            {
                ok = true;
                for (int i = 0; i < freq.Length - 1; i++)
                    if (freq[i].count < freq[i + 1].count)
                    {
                        aux = freq[i];
                        freq[i] = freq[i + 1];
                        freq[i + 1] = aux;
                        ok = false;
                    }
            }
            while (!ok);

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i].count != 0)
                    Console.Write($"{freq[i].pos} ");
            }
        }

        static void MergeSort(Data[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(a, left, mid);
                MergeSort(a, mid + 1, right);
                Interclasare(a, left, mid, right);
            }
        }
        static void Interclasare(Data[] a, int left, int mid, int right)
        {
            Data[] b = new Data[right - left + 1];
            int i = left, j = mid + 1, k = 0;
            while (i <= mid && j <= right)
            {
                if (a[i].count <= a[j].count)
                {
                    b[k] = a[i];
                    k++;
                    i++;
                }
                else
                {
                    b[k] = a[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                b[k] = a[i];
                k++;
                i++;
            }
            while (j <= right)
            {
                b[k] = a[j];
                k++;
                j++;
            }
            for (i = 0; i < k; i++)
                a[left + i] = b[i];
        }
        static void Main(string[] args)
        {
            Load("../../data2.txt");
            View(v1);
            frecventa(v1);
        }
    }
}
