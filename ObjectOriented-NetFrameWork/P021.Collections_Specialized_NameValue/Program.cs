﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P021.Collections_Specialized_NameValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating 
            NameValueCollection cities = new NameValueCollection();
            // Adding 
            cities.Add("Germany", "Berlin");
            cities.Add("Germany", "Hamburg");
            cities.Add("Germany", "Frankfurt");
            cities.Add("Italy", "Rome");
            cities.Add("Italy", "Milan");
            // Displaying
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // Set
            cities.Set("Italy", "Venice");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
            // Contains
            //cities.Clear();
            //Console.WriteLine(cities.HasKeys());
            // Remove
            cities.Remove("Italy");
            foreach (string item in cities)
            {
                Console.Write(item + ": ");
                Console.WriteLine(cities[item]);
            }
        }
    }
}
