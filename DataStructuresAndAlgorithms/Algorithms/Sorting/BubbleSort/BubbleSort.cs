using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.Sorting.BubbleSort
{
    class BubbleSort
    {
        // bubble sorting min to max
        public static int[] BubbleSortMethod(int[] data)
        {
            for(int i = 0; i < data.Length - 1; i++)
            {
                for(int j = data.Length - 1; j > 0; j--)
                {
                    // swap items if they are out of order
                    if(data[j-1] > data[j])
                    {
                        int tmp = data[j - 1];
                        data[j - 1] = data[j];
                        data[j] = tmp;
                    }
                }
            }

            return data;
        }
    }
}
