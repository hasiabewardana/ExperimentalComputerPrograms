using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.CircularQueue
{
    public class CircularQueue
    {
        private int maxSize;
        private double[] circularQueueArray;
        int front;
        int rear;
        int items;

        public CircularQueue(int max)
        {
            maxSize = max;
            circularQueueArray = new double[maxSize]; // create an array of maxSize for the queue
            front = 0;
            rear = -1;
            items = 0;
        }

        // add elements to the rear of the queue
        public void Enqueue(double el)
        {
            if (rear == maxSize - 1) // check whether the rear goes to the last position of the array
            {
                rear = -1;
            }
            circularQueueArray[++rear] = el;
            items++;
            Console.WriteLine("{0} is added to the circular queue.", el);
        }

        // get elements from the front of the queue
        public double Dequeue()
        {
            double temp = circularQueueArray[front++];

            if (front == maxSize) // check whether incremented front goes out of the array
            {
                front = 0;
            }

            items--;

            return temp;
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
        public void PrintCircularQueue()
        {
            Console.WriteLine("Printing the circular queue...");

            foreach (double el in circularQueueArray)
            {
                Console.WriteLine(el);
            }
        }
    }
}
