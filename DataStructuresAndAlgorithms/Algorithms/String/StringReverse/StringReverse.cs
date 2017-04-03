using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.String.StringReverse
{
    class StringReverse
    {
        public void ReverseString(string str)
        {
            char[] charArray = str.ToCharArray(); // get each character from the string and put them into a char array

            for(int i = 0; i < charArray.Length / 2; i++)
            {
                // swap updated opposite end elements
                char temp = charArray[i];
                charArray[i] = charArray[(charArray.Length - 1) - i];
                charArray[(charArray.Length - 1) - i] = temp;
            }

            string reversed = new string(charArray); // create a new string with swapped characters

            Console.WriteLine("String after reversing: " + reversed);
        }
    }
}
