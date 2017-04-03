using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.Queue
{
    public class Queue
    {
        private int maxSize;
        private double[] queueArray;
        int front;
        int rear;
        int items;

        public Queue(int max)
        {
            maxSize = max;
            queueArray = new double[maxSize]; // create an array of maxSize for the queue
            front = 0;
            rear = -1;
            items = 0;
        }

        // add elements to the rear of the queue
        public void Enqueue(double el)
        {
            if(!IsFull())
            {
                queueArray[++rear] = el;
                items++;
                Console.WriteLine("{0} is added to the queue.", el);
            }
            else
            {
                Console.WriteLine("Queue is full.");
            }
        }

        // get elements from the front of the queue
        public double Dequeue()
        {
            if(!IsEmpty())
            {
                double frontElement = queueArray[front++];
                items--;
                Console.WriteLine("{0} is removed from the queue.", frontElement);
                return frontElement;
            }
            else
            {
                Console.WriteLine("Queue is empty.");
                return -1;
            }
        }

        // get the front element without removing it
        public double Peek()
        {
            if(!IsEmpty())
            {
                Console.WriteLine("{0} is the front element of the queue.", queueArray[front]);
                return queueArray[front];
            }
            else
            {
                Console.WriteLine("Queue is empty.");
                return -1;
            }
        }

        // check whether the queue is empty
        public bool IsEmpty()
        {
            if (items == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // check whether the queue is full
        public bool IsFull()
        {
            if (items == maxSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // get the size of the queue
        public int Size()
        {
            return items;
        }

        // print all elements of the queue to the console
        public void PrintQueue()
        {
            Console.WriteLine("Printing the stack...");

            if (rear > -1)
            {
                foreach (double el in queueArray)
                {
                    Console.WriteLine(el);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty.");
            }
        }
    }
}
