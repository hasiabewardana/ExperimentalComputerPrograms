using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.Stack
{
    public class StackExecution
    {
        // use to demonstrate the usage of a stack
        public static void Execute()
        {
            Stack stack = new Stack(5);

            // push item to stack
            stack.Push(3);
            stack.Push(5);
            stack.Push(8);
            stack.Push(2);
            stack.Push(4);

            Console.WriteLine();

            // pop item from the stack
            stack.Pop();
            stack.Pop();

            Console.WriteLine();

            // printing the stack
            stack.PrintStack();

            Console.WriteLine();

            // clear the stack
            stack.Clear();

            Console.WriteLine();

            // printing the stack
            stack.PrintStack();

            Console.ReadLine();
        }
    }
}
