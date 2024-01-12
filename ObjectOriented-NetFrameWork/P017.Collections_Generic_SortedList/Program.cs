using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P017.Collections_Generic_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and adding to Generic SortedList");
            SortedList<string, long> phoneBook = new SortedList<string, long>
            {
                { "Jack", 823456789 },
                { "Willy", 944556789 },
                { "Charles", 123456744 },
                { "Jennifer", 623456784 },
                { "James", 10101023 }
            };
            PrintingSortedList<string, long>(phoneBook);

            //index
            ConsoleHelper.WriteLine("\nUpdate Jack phone number - Index");
            phoneBook["Jack"] = 1234567890;
            ConsoleHelper.WriteLine(phoneBook["Jack"].ToString(), ConsoleColor.Yellow);

            // TryGetValue
            ConsoleHelper.WriteLine("\nTryGetValue for James");
            phoneBook.TryGetValue("James", out long number);
            ConsoleHelper.WriteLine(number.ToString(), ConsoleColor.Yellow);

            // Remove
            ConsoleHelper.WriteLine("\n.Remove, .RemoveAt(1) - Removed Willy");
            Console.WriteLine("After Removing");
            phoneBook.Remove("Willy");
            PrintingSortedList<string, long>(phoneBook);

            //Count
            ConsoleHelper.WriteLine("\nGetting count");
            ConsoleHelper.WriteLine(phoneBook.Count.ToString(), ConsoleColor.Yellow);

            //Contains
            ConsoleHelper.WriteLine("\nContains Key and Value");
            ConsoleHelper.WriteLine("ContainsKey Jennifer " + phoneBook.ContainsKey("Jennifer").ToString(), ConsoleColor.Yellow);
            ConsoleHelper.WriteLine("ContainsValue 123456744 " + phoneBook.ContainsValue(123456744).ToString(), ConsoleColor.Yellow);

            //Get with LINQ
            ConsoleHelper.WriteLine("\nGet Jennifer with LINQ");
            KeyValuePair<string, long> z = phoneBook.FirstOrDefault(x => x.Key == "Jennifer");
            if(z.Equals(default(KeyValuePair<string, long>)))
            {
                ConsoleHelper.WriteLine("\tJennifer not found", ConsoleColor.Red);
            }
            else
            {
                ConsoleHelper.WriteLine($"\tKey: {z.Key}\t\t\tValue: {z.Value}", ConsoleColor.Yellow);
            }

        }

        static void PrintingSortedList<TKey, TValue>(SortedList<TKey, TValue> data)
        {
            foreach (var item in data)
            {
                ConsoleHelper.WriteLine($"Key: {item.Key}\t\t\t Value: {item.Value}", ConsoleColor.Yellow);
            }
            
        }
    }
}
