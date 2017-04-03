using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.String.SpaceRemove
{
    class SpaceRemove
    {
        public void RemoveSpaces(string str)
        {
            char[] charArray = str.ToCharArray(); // get each character from the string and put them into a char array
            string result = "";

            for(int i = 0; i < charArray.Length; i++)
            {
                // check whether there is a space within the string and if so go to the next iteration
                if (charArray[i] == ' ') 
                {
                    continue;
                }
                else
                {
                    result += charArray[i]; // add characters to create the final string
                }
            }

            Console.WriteLine("String after removing spaces: " + result);
        }
    }
}
