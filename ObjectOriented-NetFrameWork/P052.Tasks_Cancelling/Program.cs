using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P052.Tasks_Cancelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task task = new Task(() =>
            {
                for (int i = 1; i <= 5000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Task is cancelled");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                    
                }
                Console.WriteLine("Task is complete");
            });
            task.Start();

            //Thread.Sleep(1000);
            //cts.Cancel();

            cts.CancelAfter(1000);

            Console.ReadLine();
        }
    }
}
