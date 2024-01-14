using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P025.Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("Creating and printing a Tuple that is int, string, string, DateTime, bool");
            var empInfo = new Tuple<int, string, string, DateTime, bool>(100, "Jack", "William", new DateTime(2017, 10, 15), true);
            Console.WriteLine(empInfo.Item1);
            Console.WriteLine(empInfo.Item2);
            Console.WriteLine(empInfo.Item3);
            Console.WriteLine(((DateTime)(empInfo.Item4)).ToShortDateString());
            Console.WriteLine(empInfo.Item5);

            ConsoleHelper.WriteLine("\n\nTuple.Create: To create a Tuple");
            var studentInfo = Tuple.Create(5, "John", "Cavin", new DateTime(2003, 10, 27));
            Console.WriteLine(studentInfo.Item1);
            Console.WriteLine(studentInfo.Item2);
            Console.WriteLine(studentInfo.Item3);
            Console.WriteLine(studentInfo.Item4);

            ConsoleHelper.WriteLine("\n\nNested Tuple");
            var employeeInfo = new Tuple<int, string, string, string, string, string, string, Tuple<decimal, decimal, decimal, decimal, decimal>>
                (105, "James", "Watson", "", "", "", "", Tuple.Create(8000m, 3000m, 4000m, 5000m, 5000m));

            Console.WriteLine("Employee name is " + employeeInfo.Item2);
            Console.WriteLine("Last 5 salaries");
            Console.WriteLine(employeeInfo.Rest.Item1);
            Console.WriteLine(employeeInfo.Rest.Item2);
            Console.WriteLine(employeeInfo.Rest.Item3);
            Console.WriteLine(employeeInfo.Rest.Item4);
            Console.WriteLine(employeeInfo.Rest.Item5);

            ConsoleHelper.WriteLine("\n\nTuple with methods: Aria");
            var aria = Tuple.Create(12, "Aria", "Stark", "Winterfell");
            DisplayInformation(aria);

            ConsoleHelper.WriteLine("\n\nTuple with methods: Sansa");
            var sansa = Tuple.Create(18, "Sansa", "Stark", "Winterfell");
            DisplayInformation(sansa);

            ConsoleHelper.WriteLine("\n\nTuple Get with methods: Rob");
            var info = CreateAndReturnTuple();
            Console.WriteLine(info.Item1);
            Console.WriteLine(info.Item2);
            Console.WriteLine(info.Item3);
            Console.WriteLine(info.Item4);
        }


        public static void DisplayInformation(Tuple<int, string, string, string> personInfo)
        {
            Console.WriteLine(personInfo.Item1);
            Console.WriteLine(personInfo.Item2);
            Console.WriteLine(personInfo.Item3);
            Console.WriteLine(personInfo.Item4);
        }

        public static Tuple<int, string, string, string> CreateAndReturnTuple()
        {
            var info = Tuple.Create(25, "Rob", "Stark", "Winterfell");

            return info;
        }
    }
}
