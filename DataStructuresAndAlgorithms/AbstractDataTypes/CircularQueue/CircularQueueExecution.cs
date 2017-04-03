using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.CircularQueue
{
    public class CircularQueueExecution
    {
        //use to demonstrate the usage of a circular queue
        public static void Execute()
        {
            CircularQueue circularQueue = new CircularQueue(5);

            //insert item to queue
            circularQueue.Enqueue(3);
            circularQueue.Enqueue(5);
            circularQueue.Enqueue(8);
            circularQueue.Enqueue(2);
            circularQueue.Enqueue(4);
            circularQueue.Enqueue(9);
            circularQueue.Enqueue(7);

            Console.WriteLine();

            //remove item from the queue
            circularQueue.Dequeue();
            circularQueue.Dequeue();

            Console.WriteLine();

            //printing the Queue
            circularQueue.PrintCircularQueue();

            Console.ReadLine();
        }
    }
}
