using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P033.Delegate_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the last one is the out parameter
            //caling the first AddTwoNumbers that recieves two int params
            Func<int, int, int> funcOne = AddTwoNumbers;
            Console.WriteLine("funcOne = " + funcOne(3, 10));

            //calling the second AddTwoNumber with no in params
            Func<int> funcTwo = AddTwoNumbers;
            Console.WriteLine("funcTwo = " + funcTwo());
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static int AddTwoNumbers()
        {
            int x = 5;
            int y = 2;
            int z = x + y;
            return z;
        }
    }
}
