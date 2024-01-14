using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P027.Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(x.IsGreater(10));

            string text = "100";
            Console.WriteLine(text.IsNumber());

            DateTime myDate = new DateTime(2024, 1, 14);
            Console.WriteLine(myDate.MyCustomFormat());
        }
    }

    static class MyCustomExtension
    {
        public static bool IsGreater(this int value, int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }

        public static string MyCustomFormat(this DateTime date)
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}", date);
        }
    }
}
