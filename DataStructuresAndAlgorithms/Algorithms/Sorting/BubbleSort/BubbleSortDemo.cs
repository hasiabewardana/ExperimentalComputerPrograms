using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting.BubbleSort
{
    public class BubbleSortDemo
    {
        // use to demonstrate bubble sorting
        public static void ExecuteDemo()
        {
            // data to sort
            int[] arr = { 8, 3, 4, 7, 2 };

            arr = BubbleSort.BubbleSortMethod(arr);

            // print sorted array
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
