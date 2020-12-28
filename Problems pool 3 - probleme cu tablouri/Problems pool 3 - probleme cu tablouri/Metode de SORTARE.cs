using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_pool_3___probleme_cu_tablouri
{
    /// <summary>
    /// <example>
    /// RESRUSA1: https://www.geeksforgeeks.org/time-complexities-of-all-sorting-algorithms/
    /// RESURSA2: https://www.toptal.com/developers/sorting-algorithms
    /// </example>
    /// </summary>
    class Metode_de_SORTARE
    {
        /// <summary>
        /// The selection sort algorithm sorts an array by repeatedly finding the minimum element 
        /// (considering ascending order) from unsorted part and putting it at the beginning. 
        /// The algorithm maintains two subarrays in a given array.
        /// </summary>
        /// <param name="arr"></param>
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // gaseste minimul in vectorul nesortat
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Intershimbarea minimului gasit cu primul element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        /// <summary>
        /// To sort an array of size n in ascending order:
        /// 1: Iterate from arr[1] to arr[n] over the array.
        /// 2: Compare the current element (key) to its predecessor.
        /// 3: If the key element is smaller than its predecessor, compare it to the elements before. 
        /// Move the greater elements one position up to make space for the swapped element.
        /// </summary>
        /// <param name="arr"></param>
        /// 
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

        /// <summary>
        /// Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the 
        /// adjacent elements if they are in wrong order.
        /// </summary>
        /// <param name="arr"></param>
        /// 
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // interschimbare temp si arr[i] 
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }

        /// <summary>
        /// It divides the input array into two halves, calls itself for the two halves, 
        /// and then merges the two sorted halves. The merge() function is used for merging two halves. 
        /// The merge(arr, l, m, r) is a key process that assumes that arr[l..m] and arr[m+1..r] are 
        /// sorted and merges the two sorted sub-arrays into one. 

        /* MergeSort(arr[], l, r)
         If r > l
      1. Find the middle point to divide the array into two halves:  
              middle m = (l + r) / 2
      2. Call mergeSort for first half:   
              Call mergeSort(arr, l, m)
      3. Call mergeSort for second half:
              Call mergeSort(arr, m+1, r)
      4. Merge the two halves sorted in step 2 and 3:
              Call merge(arr, l, m, r)*/
        /// </summary>
        /// <param name="arr"></param>
        /// 

        static void merge(int[] arr, int l, int m, int r)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = m - l + 1;
            int n2 = r - m;

            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                // Find the middle
                // point
                int m = (l + r) / 2;

                // Sort first and
                // second halves
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);

                // Merge the sorted halves
                merge(arr, l, m, r);
            }
        }

        /// <summary>
        ///This function takes last element as pivot, 
        ///places the pivot element at its correct position in sorted array, and places all
        ///smaller(smaller than pivot) to left of pivot and all greater elements to rightof pivot
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// 
        static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (arr[j] < pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }

        /* The main function that implements QuickSort() 
    arr[] --> Array to be sorted, 
    low --> Starting index, 
    high --> Ending index */
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        // Afiseaza vectorul
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 64, 25, 12, 22, 11 };
            int[] arr2 = { 23, 67, 45, 23, 66, 98, 12 };
            int[] arr3 = { 55, 78, 23, 44, 56, 12, 11 };
            int[] arr4 = { 78, 89, 100, 456, 23, 589, 1111 };
            int[] arr5 = { 88, 99, 23, 33, 444, 122, 121, 5768 };
            Console.WriteLine("Vectorii de mai jos sunt sortati folosind urmatoarele metode: ");
            Console.WriteLine();

            SelectionSort(arr1);
            Console.Write("\t<Selection Sort>: ");
            printArray(arr1);
            Console.WriteLine();

            InsertionSort(arr2);
            Console.Write("\t<Insertion Sort>: ");
            printArray(arr2);
            Console.WriteLine();

            BubbleSort(arr3);
            Console.Write("\t<Buble Sort>: ");
            printArray(arr3);
            Console.WriteLine();

            MergeSort(arr4, 0, arr4.Length - 1);
            Console.Write("\t<Merge Sort>: ");
            printArray(arr4);
            Console.WriteLine();

            QuickSort(arr5, 0, arr5.Length-1);
            Console.Write("\t<Quick Sort>: ");
            printArray(arr5);
            Console.WriteLine();

            Console.WriteLine("Pentru mai multe informatii: https://www.geeksforgeeks.org/time-complexities-of-all-sorting-algorithms/");
            Console.WriteLine("Pentru ilustratii: https://www.toptal.com/developers/sorting-algorithms");
            Console.ReadKey();
        }
    }
}
