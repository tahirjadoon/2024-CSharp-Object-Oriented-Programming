using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P012.Collections_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and adding to Queue");
            // Creating
            Queue queue = new Queue();
            // Adding
            queue.Enqueue("Cavin");
            queue.Enqueue("Tom");
            queue.Enqueue("Emma");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing
            ConsoleHelper.WriteLine("Removing from Queue");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
