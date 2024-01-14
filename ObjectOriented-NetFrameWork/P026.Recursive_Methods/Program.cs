using OOP.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P026.Recursive_Methods
{
    internal class Program
    {
        private const int _indent = 0;
        private const int _increment = 2;
        private const char _character = ' ';
        static void Main(string[] args)
        {
            //display all folders in the downloads recursively. 
            //indent the the child folder by 2 spaces 
            var path = @"C:\Users\T460SU\Downloads";
            DisplayFolders(path, _indent);
        }

        static void DisplayFolders(string path, int indent)
        {
            foreach(var folder in Directory.GetDirectories(path))
            {
                var color = PickColor(indent);
                var lead = indent == _indent ? "" : new string(_character, indent);
                ConsoleHelper.WriteLine($"{lead}{Path.GetFileName(folder)}", color);
                DisplayFolders(folder, indent + _increment);
            }
        }

        static ConsoleColor PickColor(int indent)
        {
            //convert the number from 1 to 10 to pick the colors
            var pick = indent;
            if (pick == 0)
            {
                pick = 1;
            }
            else
            {
                pick = (pick / _increment) +1;
            }
            
            if(pick > 10)
            {
                //find the ten that the number belong to and subtract 1 from it
                var ten = (int)Math.Ceiling(pick / 10.0) * 10;
                pick = pick - (ten - 1);
            }

            ConsoleColor color = ConsoleColor.Green;
            switch(pick)
            {
                case 1:
                    color = ConsoleColor.Green;
                    break;
                case 2:
                    color = ConsoleColor.Yellow;
                    break;
                case 3:
                    color = ConsoleColor.Blue;
                    break;
                case 4:
                    color = ConsoleColor.Cyan;
                    break;
                case 5:
                    color = ConsoleColor.Magenta;
                    break;
                case 6:
                    color = ConsoleColor.DarkGreen;
                    break;
                case 7:
                    color = ConsoleColor.DarkYellow;
                    break;
                case 8:
                    color = ConsoleColor.DarkBlue;
                    break;
                case 9:
                    color = ConsoleColor.DarkCyan;
                    break;
                case 10:
                    color = ConsoleColor.DarkMagenta;
                    break;
                default:
                    color = ConsoleColor.Green;
                    break;
            }
            return color;
        }
    }
}
