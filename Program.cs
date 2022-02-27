using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {


        static int Partition(int[] array, int low,
                                    int high)
    {
    
        int pivot = array[high];

        int lowIndex = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                lowIndex++;

                int temp = array[lowIndex];
                array[lowIndex] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[lowIndex + 1];
        array[lowIndex + 1] = array[high];
        array[high] = temp1;

        return lowIndex + 1;
    }

    static void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);

            Sort(array, low, partitionIndex - 1);
            Sort(array, partitionIndex + 1, high);
        }
    }


        static void Main(string[] args)
        {

            Stopwatch stopWatch = new Stopwatch();         

                Random rnd = new Random();
                int tal = 16000; 

                int[] arr = new int[tal];
                for (int i = 0; i < tal; i++) {
                    arr[i] = rnd.Next(1, tal);
                }

                stopWatch.Start();

                Sort(arr, 0, tal - 1);

                stopWatch.Stop();

                foreach (int a in arr){
                Console.Write(a + " ");
                }



            

            Console.WriteLine("");
            Console.WriteLine("Det tog " + stopWatch.Elapsed.TotalMilliseconds + " Millisekunder");

        }

        
    }
}