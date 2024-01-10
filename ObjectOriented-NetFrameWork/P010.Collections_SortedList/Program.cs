using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P010.Collections_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and adding to SortedList");
            // Creating
            SortedList sortedList = new SortedList();

            // Adding
            sortedList.Add(1, "Jan");
            sortedList.Add(2, "Feb");
            sortedList.Add(3, "Mar");
            sortedList.Add(4, "Apr");
            sortedList.Add(5, "May");

            PrintForEach(sortedList);
            PrintFor(sortedList);

            // Index
            ConsoleHelper.WriteLine("Pick by index 5");
            ConsoleHelper.WriteLine($"{sortedList[5].ToString()}", ConsoleColor.Green);

            //capacity
            ConsoleHelper.WriteLine("Capacity");
            ConsoleHelper.WriteLine($"{sortedList.Count}", ConsoleColor.Green);

            // Remove
            ConsoleHelper.WriteLine("Remove by key. To remove by index use RemoveaAt");
            sortedList.Remove(1);
            PrintForEach(sortedList);

            // Contains
            ConsoleHelper.WriteLine("Contains Apr");
            ConsoleHelper.WriteLine($"{sortedList.ContainsValue("Apr")}", ConsoleColor.Green);

            // Copy to ArrayList
            ConsoleHelper.WriteLine("Copy to Array list");
            ArrayList array = new ArrayList(sortedList.Values);
            PrintArray(array);
        }

        static void PrintForEach(SortedList sl)
        {
            ConsoleHelper.WriteLine("Print with ForEach", ConsoleColor.Cyan);
            foreach (DictionaryEntry item in sl)
            {
                ConsoleHelper.WriteLine($"{item.Key}: {item.Value}", ConsoleColor.Yellow);
            }
        }

        static void PrintFor(SortedList sl)
        {
            ConsoleHelper.WriteLine("Print with ForLoop", ConsoleColor.Cyan);
            for (int i = 0; i < sl.Count; i++)
            {
                ConsoleHelper.WriteLine($"{sl.GetKey(i)}: {sl.GetByIndex(i)}", ConsoleColor.Yellow);
            }
        }

        static void PrintArray(ArrayList array)
        {
            ConsoleHelper.WriteLine("Printing ArrayList", ConsoleColor.Cyan);
            foreach (var item in array)
            {
                ConsoleHelper.WriteLine(item.ToString(), ConsoleColor.Yellow);
            }
        }
    }
}
