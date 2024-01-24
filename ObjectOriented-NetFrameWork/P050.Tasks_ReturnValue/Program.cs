using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P050.Tasks_ReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for(int i = 1; i <= 5; i++)
                {
                    result += i;
                    ConsoleHelper.WriteLine($"{i}: result = {result}", ConsoleColor.Yellow);
                }
                return result;
            });
            task.Start();

            ConsoleHelper.WriteLineLock($"Return value for result: {task.Result}", ConsoleColor.Green);

            Console.ReadLine();

        }
    }
}
