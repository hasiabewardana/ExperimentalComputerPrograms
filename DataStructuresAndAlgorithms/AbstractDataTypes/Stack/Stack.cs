using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.Stack
{
    public class Stack
    {
        private int maxSize;
        private double[] stackArray;
        private int top;

        public Stack(int max)
        {
            maxSize = max;
            stackArray = new double[maxSize]; // create an array of maxSize for the stack
            top = -1;
        }

        // add elements to the top of the stack
        public void Push(double el)
        {
            if(!IsFull())
            {
                stackArray[++top] = el;
                Console.WriteLine("{0} is added to the stack.", el);
            }
            else
            {
                Console.WriteLine("Stack is full.");
            }
        }

        // get elements from the top of the stack
        public double Pop()
        {
            if(!IsEmpty())
            {
                double topElement = stackArray[top--];
                Console.WriteLine("{0} is popped from the stack.", topElement);
                return topElement;
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
        }

        // get the top element without removing
        public double Peek()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("{0} is the top eeement of the stack.", stackArray[top]);
                return stackArray[top];
            }
            else
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }
        }

        // clear whole stack array
        public void Clear()
        {
            maxSize = 0;
            stackArray = null;
            top = -1;
            Console.WriteLine("Stack is cleared.");
        }

        // check whether the stack is empty
        public bool IsEmpty()
        {
            if(top == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check whether the stack is full
        public bool IsFull()
        {
            if (top == maxSize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // print all elements of the stack to the console
        public void PrintStack()
        {
            Console.WriteLine("Printing the stack...");

            if (top > -1)
            {
                foreach (double el in stackArray)
                {
                    Console.WriteLine(el);
                }
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }
    }
}
