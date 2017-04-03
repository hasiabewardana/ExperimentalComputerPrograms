using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.AbstractDataTypes.Queue
{
    public class QueueExecution
    {
        // use to demonstrate the usage of a queue
        public static void Execute()
        {
            Queue queue = new Queue(5);

            // insert item to queue
            queue.Enqueue(3);
            queue.Enqueue(5);
            queue.Enqueue(8);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(9);

            Console.WriteLine();

            // remove item from the queue
            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine();

            // printing the Queue
            queue.PrintQueue();

            Console.ReadLine();
        }
    }
}
