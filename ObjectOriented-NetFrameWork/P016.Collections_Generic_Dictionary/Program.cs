using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P016.Collections_Generic_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating
            ConsoleHelper.WriteLine("Creating dictionary and initializing - two way to add items");
            Dictionary<string, string> capitals = new Dictionary<string, string>()
            {
                { "Russia", "Moscow" },
                { "Italy", "Rome" }
            };
            //adding additional items manually
            capitals.Add("England", "London");
            capitals.Add("Spain", "Madrid");
            capitals.Add("Germany", "Berlin");
            PrintDictionary(capitals);

            // Index
            Console.WriteLine("\nChanging the Key Italy to value Venice");
            capitals["Italy"] = "Venice";
            PrintDictionary(capitals);

            // Try get value
            Console.WriteLine("\nTry get value for Russia");
            capitals.TryGetValue("Russia", out string result);
            if (result != null)
                ConsoleHelper.WriteLine("Result is " + result, ConsoleColor.Yellow);

            // Remove
            Console.WriteLine("\nRemove Italy .Remove single item, .Clear() clears the dictionary completly");
            capitals.Remove("Italy");
            PrintDictionary(capitals);

            // Contains
            Console.WriteLine("\nContains France");
            ConsoleHelper.WriteLine(capitals.ContainsKey("France").ToString(), ConsoleColor.Yellow);
        }

        static void PrintDictionary(Dictionary<string, string> items)
        {
            foreach (var item in items)
            {
                ConsoleHelper.WriteLine($"Key: {item.Key}\t\t\tValue: {item.Value}", ConsoleColor.Yellow);
            }
        }
    }
}
