using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP.Core
{
    public static class ConsoleHelper
    {
        static object writeLock = new object();

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
                Console.ResetColor();// = defaultColor;
            }
        }
        public static void WriteLineLock(string message)
        {
            WriteLineLock(message, null);
        }

        public static void WriteLineLock(string message, ConsoleColor? color)
        {
            lock (writeLock)
            {
                WriteLine(message, color);
            }
            
        }
    }
}
