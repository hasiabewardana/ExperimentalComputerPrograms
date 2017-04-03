using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.String.StringReverse
{
    public class StringReverseDemo
    {
        // use to demonstrate string reversing
        public static void ExecuteDemo()
        {
            StringReverse stringReverse = new StringReverse();

            Console.Write("Enter a string to reverse: ");
            stringReverse.ReverseString(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
