using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045.Parallel_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
            () => {
                PrintCount(-100, 0, "negative");
            },
            () => {
                PrintCount(1, 100, "positive");
            }
        );
        }

        static void PrintCount(int LowLimit, int UpperLimit, string text)
        {
            for (int i = LowLimit; i <= UpperLimit; i++)
            {
                Console.WriteLine($"> {text} {i}");
            }
        }
    }
}
