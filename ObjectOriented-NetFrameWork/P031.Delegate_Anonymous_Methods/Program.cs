using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P031.Delegate_Anonymous_Methods
{
    internal class Program
    {
        delegate void DisplayInfoDelegate();
        delegate void DisplayInfoBasedOnNumberDelegate(int number);

        static void Main(string[] args)
        {
            //normal delegates as we have seen before. 
            ConsoleHelper.WriteLine("Normal Delegate", ConsoleColor.Yellow);

            DisplayInfoDelegate normalDelegate = new DisplayInfoDelegate(GetInformation);
            normalDelegate();

            DisplayInfoBasedOnNumberDelegate oneParameterDelegate = new DisplayInfoBasedOnNumberDelegate(GetInformation);
            oneParameterDelegate(100);

            ConsoleHelper.WriteLine("\n----------------------\n", ConsoleColor.Cyan);

            //anonymous delegate
            ConsoleHelper.WriteLine("Delegate with anonymous method", ConsoleColor.Yellow);

            DisplayInfoDelegate normalDelegateAnonymous = delegate { Console.WriteLine("Hi from the anonymous method"); };
            normalDelegateAnonymous();

            DisplayInfoBasedOnNumberDelegate oneParameterDelegateAnonymous =
                delegate (int x) { Console.WriteLine("Hi from the anonymous method which takes one int parameter " + x); };
            oneParameterDelegateAnonymous(150);
        }

        public static void GetInformation()
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with no parameter");
        }

        public static void GetInformation(int x)
        {
            // Some logic goes in here
            Console.WriteLine("Delegate with one parameter : " + x);
        }
    }
}
