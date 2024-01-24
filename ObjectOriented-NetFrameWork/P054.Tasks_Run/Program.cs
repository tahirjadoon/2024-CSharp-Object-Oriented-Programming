using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P054.Tasks_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHiTask();

            AddNumbers(1, 2, 3, 4, 5, 6);

            Console.ReadLine();
        }

        private static Task SayHiTask()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hi there from the task");
            });
        }

        private static Task AddNumbers(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started...");
                int result = 0;
                foreach(int number in numbers)
                {
                    result += number;
                }
                Console.WriteLine($"Total: {result}");
            });
        }
    }
}
