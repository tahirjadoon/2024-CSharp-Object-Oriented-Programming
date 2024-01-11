using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P015.Collections_Generic_List_T
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating
            ConsoleHelper.WriteLine("Creating two list List<string> as firstList and IList<string> as secondList");
            List<string> firstList = new List<string>();
            IList<string> secondList = new List<string>();
            ConsoleHelper.WriteLine("\tAdding items to firstList - List<string>", ConsoleColor.Cyan);
            firstList.Add("England");
            firstList.Add("Hungary");
            firstList.Add("China");
            firstList.Add("Germany");
            firstList.Add("Egypt");
            ConsoleHelper.WriteLine("\tPrinting firstList - List<string>", ConsoleColor.Cyan);
            PrintList<string>(firstList, "\t\t");

            //capacity
            ConsoleHelper.WriteLine("Count of firstList");
            ConsoleHelper.WriteLine($"\t{firstList.Count}", ConsoleColor.Green);

            // Sorting
            ConsoleHelper.WriteLine("After Sorting firstList...");
            firstList.Sort();
            PrintList<string>(firstList, "\t");

            // Reversing
            Console.WriteLine("After Reversing firstList...");
            firstList.Reverse();
            PrintList<string>(firstList, "\t");

            Console.WriteLine("After Removing from firstList Germany by name and index 0...");
            ConsoleHelper.WriteLine("\t\tfirstList.Clear() will clear all elements");
            firstList.Remove("Germany");
            firstList.RemoveAt(0);
            PrintList<string>(firstList, "\t");

            // Contains
            ConsoleHelper.WriteLine("Checking with contains for Egypt");
            ConsoleHelper.WriteLine($"\t{firstList.Contains("Egypt").ToString()}", ConsoleColor.Green);

            // GetRange
            ConsoleHelper.WriteLine("Getting with range from firtsList and moving to secondList");
            secondList = firstList.GetRange(0, 3);
            Console.WriteLine("\tNow we are in the second list");
            PrintList<string>(secondList, "\t");
        }

        static void PrintList<T>(IList<T> list, string append = "")
        {
            foreach(var item in list)
            {
                ConsoleHelper.WriteLine($"{append}{item}", ConsoleColor.Yellow);
            }
        }
    }
}
