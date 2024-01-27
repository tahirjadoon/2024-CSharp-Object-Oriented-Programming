using OOP.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P056.Concurrent_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Thread addData1 = new Thread(() =>
            {
                var t1 = "AddData-1";
                ConsoleHelper.WriteLine($"Thread {t1} is filling the bag", ConsoleColor.Yellow);
                for (int i = 0; i< 10; i++)
                {
                    bag.Add(i);
                    ConsoleHelper.WriteLine($"Thread {t1} added number {i}", ConsoleColor.Yellow);
                }
                ConsoleHelper.WriteLine($"Thread {t1} is complete", ConsoleColor.Yellow);
            });

            Thread addData2 = new Thread(() =>
            {
                var t2 = "AddData-2";
                ConsoleHelper.WriteLine($"Thread {t2} is filling the bag", ConsoleColor.Cyan);
                for (int i = 11; i <= 25; i++)
                {
                    bag.Add(i);
                    ConsoleHelper.WriteLine($"Thread {t2} added number {i}", ConsoleColor.Cyan);
                }
                ConsoleHelper.WriteLine($"Thread {t2} is complete", ConsoleColor.Cyan);
            });

            Thread readData1 = new Thread(() =>
            {
                //join make sures that add has finished
                addData1.Join();
                addData2.Join();

                var t3 = "ReadData-1";
                ConsoleHelper.WriteLine($"Thread {t3} has started", ConsoleColor.Magenta);
                foreach (var item in bag)
                {
                    ConsoleHelper.WriteLine($"Thread {t3} bag item = {item}", ConsoleColor.Magenta);
                }
                ConsoleHelper.WriteLine($"Thread {t3} has completed", ConsoleColor.Magenta);
            });

            addData1.Start();
            addData2.Start();
            readData1.Start();
        }
    }
}
