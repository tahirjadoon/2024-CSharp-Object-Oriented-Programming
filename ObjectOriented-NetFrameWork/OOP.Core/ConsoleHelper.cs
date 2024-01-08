using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Core
{
    public static class ConsoleHelper
    {
        public static void WriteLine(string message) 
        {
            WriteLine(message, null); 
        }

        public static void WriteLine(string message, ConsoleColor? color)
        {
            var defaultColor = Console.ForegroundColor;
            if (color != null)
            {
                Console.ForegroundColor = color.GetValueOrDefault();
            }
            Console.WriteLine(message);
            if (color != null)
            {
                Console.ForegroundColor = defaultColor;
            }
        }
    }
}
