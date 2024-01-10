using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P011.Collections_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and adding to Stack");

            Stack stack = new Stack();

            // Adding
            stack.Push("David");
            stack.Push("Emmy");
            stack.Push("Jack");
            stack.Push("Emma");

            PrintStack(stack);

            // Removing
            ConsoleHelper.WriteLine("Removing - Pop two items. Returns the item popped");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            PrintStack(stack);
        }

        static void PrintStack(Stack st)
        {
            foreach (var elem in st)
            {
                ConsoleHelper.WriteLine(elem.ToString(), ConsoleColor.Yellow);
            }
        }
    }
}
