using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P048.Semaphore
{
    internal class Program
    {
        private static System.Threading.Semaphore semaphore = new System.Threading.Semaphore(2, 2);

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ThreadStart(delegate ()
                {
                    for (int d = 0; d < 2; d++)
                    {
                        UseResource(d);
                    }
                }));
                newThread.Name = String.Format("(Thread no. {0})", i + 1);
                newThread.Start();
            }
        }

        private static void UseResource(int x)
        {
            Console.WriteLine("{0} is requesting the enter for d={1}", Thread.CurrentThread.Name, x);
            semaphore.WaitOne();

            Console.WriteLine("{0} has entered the critical section for d={1}", Thread.CurrentThread.Name, x);
            Thread.Sleep(10000);
            Console.WriteLine("{0} is leaving the critical section for d={1}", Thread.CurrentThread.Name, x);

            semaphore.Release();
            Console.WriteLine("{0} has left the critical section for d={1}", Thread.CurrentThread.Name, x);
        }
    }
}
