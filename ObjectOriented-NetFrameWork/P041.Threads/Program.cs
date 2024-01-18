using OOP.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P041.Threads
{
    internal class Program
    {
        private const int _loopSize = 10;
        private static Thread t1;
        private static Thread t2;

        static void Main(string[] args)
        {
            t1 = new Thread(new ThreadStart(SayHiEnglish));
            t1.Name = "Thread 1 - English";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHiSpanish));
            t2.Name = "Thread 2 - Spanish";
            t2.Start();

            //lambda expression
            var t3 = new Thread(new ThreadStart(() => ConsoleHelper.WriteLine("Hello from lambda exp", ConsoleColor.Blue)));
            t3.Name = "Thread 3 - Lambda";
            t3.Start();

            //anonymous method
            var t4 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 3; i++)
                {
                    ConsoleHelper.WriteLine("Hello from anonymous method", ConsoleColor.Green);
                }
            }));
            t4.Start();
        }

        static void SayHiEnglish()
        {
            ConsoleHelper.WriteLine($"Starting to execute {Thread.CurrentThread.Name}", ConsoleColor.Magenta);
            for (int i = 0; i < _loopSize; i++)
            {
                Thread.Sleep(500);
                if(i == 7)
                {
                    ConsoleHelper.WriteLine($"{Thread.CurrentThread.Name} aborted: {i}", ConsoleColor.Magenta);
                    t1.Abort();
                }
                ConsoleHelper.WriteLine($"Hi...{i} Magenta", ConsoleColor.Magenta);
            }
        }

        static void SayHiSpanish()
        {
            ConsoleHelper.WriteLine($"Starting to execute {Thread.CurrentThread.Name}", ConsoleColor.Cyan);
            for (int i = 0; i < _loopSize; i++)
            {
                Thread.Sleep(500);
                if(i == 8)
                {
                    ConsoleHelper.WriteLine($"{Thread.CurrentThread.Name} aborted: {i}", ConsoleColor.Cyan);
                    t2.Abort();
                }
                ConsoleHelper.WriteLine($"Hola...{i} Cyan", ConsoleColor.Cyan);
            }
        }
    }
}
