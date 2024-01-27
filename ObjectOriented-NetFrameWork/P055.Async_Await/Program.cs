using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P055.Async_Await
{
    internal class Program
    {
        static string processConnectToDatabase = "(Connecting to database)";
        static string processGetDataFromDatabase = "(Getting data from database)";
        static ConsoleColor color = ConsoleColor.Blue;

        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Inside the main method");

            RunProcess(1, 1_000_000, ConsoleColor.Yellow);

            var dbTask = ConnectToDatabaseProcessAndGetData();
            ConsoleHelper.WriteLine("\nBack to the main method.", ConsoleColor.Gray);
            //dbTask.Wait();
            if (dbTask.Status == TaskStatus.RanToCompletion)
                ConsoleHelper.WriteLine($"\nProcess {processConnectToDatabase} is completed.", ConsoleColor.Gray);
            else
                ConsoleHelper.WriteLine($"\nProcess {processConnectToDatabase} is NOT completed.", ConsoleColor.Gray);

            RunProcess(2, 1_000_000, ConsoleColor.Cyan);
            RunProcess(3, 1_000_000, ConsoleColor.Red);
            RunProcess(4, 1_000_000, ConsoleColor.Magenta);

            Console.ReadLine();
        }

        private static void RunProcess(int processNumber, int processLoopCondition, ConsoleColor color)
        {
            ConsoleHelper.WriteLine("\nControl is with process " + processNumber, color);
            ConsoleHelper.WriteLine($"\tProcess ({processNumber}) has started.", color);
            ConsoleHelper.WriteLine($"\tProcess ({processNumber}) is running...", color);
            for (int i = 1; i <= processLoopCondition; i++)
            {
            }
            ConsoleHelper.WriteLine($"\tProcess ({processNumber}) is complete!", color);
            ConsoleHelper.WriteLine("\tGiving control back to main method.", color);
        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            ConsoleHelper.WriteLine($"\nControl is with process {processConnectToDatabase}.", color);
            ConsoleHelper.WriteLine($"\tProcess {processConnectToDatabase} has started.", color);
            ConsoleHelper.WriteLine($"\tProcess {processConnectToDatabase} is running...", color);
            await Task.Run(() =>
            {
                ConsoleHelper.WriteLine("\tStart executing process in the await section.", color);
                Thread.Sleep(7000);
                RunProcess(10, 100000, ConsoleColor.Green);
                ConsoleHelper.WriteLine("\nProcess in the await section is complete!", color);
            });
            ConsoleHelper.WriteLine($"\tProcess {processConnectToDatabase} is complete!", color);
            ConsoleHelper.WriteLine($"\tControl is with process {processGetDataFromDatabase} again", color);
            for (int i = 0; i < 10; i++)
            {
                ConsoleHelper.WriteLine("\tGetting data..... " + i, color);
            }
            ConsoleHelper.WriteLine($"\tProcess {processGetDataFromDatabase} is complete!", color);
        }
    }
}
