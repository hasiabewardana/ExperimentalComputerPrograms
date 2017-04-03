using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Algorithms.String.SpaceRemove
{
    public class SpaceRemoveDemo
    {
        // use to demonstrate space removing
        public static void ExecuteDemo()
        {
            SpaceRemove spaceRemove = new SpaceRemove();

            Console.Write("Enter a string to remove spaces: ");
            spaceRemove.RemoveSpaces(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
