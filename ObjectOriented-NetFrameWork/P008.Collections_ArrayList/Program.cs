using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P008.Collections_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating            
            ArrayList array = new ArrayList();
            // Adding 
            array.Add("James");
            array.Add("David");
            array.Add("Charles");
            array.Add("Ahmad");
            Console.WriteLine("At first");
            ConsoleHelper.WriteLine("Count is " + array.Count, ConsoleColor.Green);
            PrintArray(array);

            Console.WriteLine("---------");
            Console.WriteLine("After insertion");
            array.Insert(2, "Tim");
            ConsoleHelper.WriteLine("Count is " + array.Count, ConsoleColor.Green);
            PrintArray(array);

            // Index
            Console.WriteLine("---------");
            Console.WriteLine("Index 2");
            ConsoleHelper.WriteLine(array[2].ToString(), ConsoleColor.Yellow);

            // Sorting
            Console.WriteLine("---------");
            array.Sort();
            Console.WriteLine("After Sorting");
            PrintArray(array);

            // Reversing
            Console.WriteLine("---------");
            array.Reverse();
            Console.WriteLine("After Reversing");
            PrintArray(array);

            // Removing
            Console.WriteLine("---------");
            Console.WriteLine("After Removing");
            Console.WriteLine("Remove James");
            array.Remove("James");
            PrintArray(array);
            array.RemoveAt(2);
            Console.WriteLine("Remove index 2");
            PrintArray(array);

            // Remove all
            Console.WriteLine("---------");
            Console.WriteLine("After Removing with range");
            array.RemoveRange(1, 2);
            PrintArray(array);

            //Adding two removed back
            Console.WriteLine("---------");
            Console.WriteLine("Adding removed back");
            array.Add("James");
            array.Add("Ahmad");
            PrintArray(array);

            // Contains
            Console.WriteLine("---------");
            Console.WriteLine("After Asking if contains James");
            ConsoleHelper.WriteLine(array.Contains("James").ToString(), ConsoleColor.Yellow);

            // GetRange
            Console.WriteLine("---------");
            Console.WriteLine("After Get Range");
            ArrayList names = new ArrayList();
            names = array.GetRange(0, 2);
            PrintArray(names);

        }

        static void PrintArray(ArrayList array)
        {
            foreach (var item in array)
            {
                ConsoleHelper.WriteLine(item.ToString(), ConsoleColor.Yellow);
            }
        }
    }
}
