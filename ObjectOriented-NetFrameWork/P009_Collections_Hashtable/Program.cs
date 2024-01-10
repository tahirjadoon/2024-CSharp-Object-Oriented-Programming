using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace P009_Collections_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and adding to Hashtable");
            // Creating
            Hashtable hash = new Hashtable();

            // Adding
            hash.Add("Microsoft", "USA");
            hash.Add("Sony", "Japan");
            hash.Add("IKEA", "Sweden");
            hash.Add("Mercedes", "Germany");
            PrintHashTable(hash);

            ConsoleHelper.WriteLine($"Count: {hash.Count.ToString()}", ConsoleColor.Green);

            // Remove
            Console.WriteLine("------------");
            Console.WriteLine("After Removing IKEA");
            hash.Remove("IKEA");
            PrintHashTable(hash);

            // Contains
            Console.WriteLine("------------");
            Console.WriteLine("Contains condition Japan");
            if (hash.ContainsValue("Japan"))
            {
                ConsoleHelper.WriteLine("Yes Japan is included", ConsoleColor.Green);
            }
            else
            {
                ConsoleHelper.WriteLine("No it is not", ConsoleColor.Red);
            }

            // Copy to ArrayList
            Console.WriteLine("------------");
            Console.WriteLine("After copying keys to array list");
            ArrayList array = new ArrayList(hash.Keys);
            PrintArray(array);
        }

        static void PrintHashTable(Hashtable ht)
        {
            //item is of type DictionaryEntry
            foreach (DictionaryEntry item in ht)
            {
                ConsoleHelper.WriteLine($"{item.Key}: {item.Value}", ConsoleColor.Yellow);
            }
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
