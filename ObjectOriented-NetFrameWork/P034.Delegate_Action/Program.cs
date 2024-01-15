using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034.Delegate_Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int> action1 = DisplayInformation;
            action1(16);

            Action action2 = DisplayInformation;
            action2();
;        }

        public static void DisplayInformation(int number)
        {
            Console.WriteLine($"The info with number as {number}");
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("The info without in number");
        }
    }
}
