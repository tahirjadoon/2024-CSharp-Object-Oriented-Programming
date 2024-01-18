using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P042.Multithreading
{
    public delegate void loopOne();
    public delegate void loopTwo();
    public delegate void loopThree();

    internal class Program
    {
        static void Main(string[] args)
        {
            NonMultithreaded();
            Multithreaded();
        }

        static void NonMultithreaded()
        {
            ConsoleHelper.WriteLine("NonMultithreaded", ConsoleColor.Yellow);
            loopOne loop1 = (delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 1_500_000_000; i++)
                { }
                Console.WriteLine("Process 1 has been completed \n");
            });
            loop1();

            loopTwo loop2 = (delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 1_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 has been completed \n");
            });
            loop2();

            loopThree loop3 = (delegate ()
            {
                Console.WriteLine("Process 3 started");
                Console.WriteLine("Process 3 is running");
                for (long i = 0; i < 1_000_000_000; i++)
                { }
                Console.WriteLine("Process 3 has been completed \n");
            });
            loop3();
        }

        static void Multithreaded()
        {
            ConsoleHelper.WriteLine("\nMultithreaded", ConsoleColor.Yellow);
            Thread t1 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 1 started");
                Console.WriteLine("Process 1 is running");
                for (long i = 0; i < 1_500_000_000; i++)
                { }
                Console.WriteLine("Process 1 has been completed \n");
            }));
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(delegate ()
            {
                Console.WriteLine("Process 2 started");
                Console.WriteLine("Process 2 is running");
                for (long i = 0; i < 1_000_000_000; i++)
                { }
                Console.WriteLine("Process 2 has been completed \n");
            }));
            t2.Start();

            Thread t3 = new Thread(new ThreadStart(delegate ()
            {
                Thread.Sleep(1);
                Console.WriteLine("Process 3 started");
                Console.WriteLine("Process 3 is running");
                for (long i = 0; i < 1_000_000_000; i++)
                { }
                Console.WriteLine("Process 3 has been completed \n");
            }));
            t3.Start();
        }
    }
}
