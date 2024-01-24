using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P053.Tasks_Wait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(() =>
            {
                DisplayMessage(1, 8000);
            });
            t1.Start();
            t1.Wait(); //all other tasks will wait for t1 to complete

            Task t2 = new Task(() =>
            {
                DisplayMessage(2, 6000);
            });
            t2.Start();
            t2.Wait(); //t3 will wait for t2 to finish

            Task t3 = new Task(() =>
            {
                DisplayMessage(3, 2000);
            });
            t3.Start();

            Task.WaitAll(t1, t2, t3);
        }

        static void DisplayMessage(int number, int waitSeconds)
        {
            Console.WriteLine($"Task {number} started");
            Console.WriteLine($"Task {number} running...\n");
            Thread.Sleep( waitSeconds );
            Console.WriteLine($"Task {number} finished");
        }
    }
}
