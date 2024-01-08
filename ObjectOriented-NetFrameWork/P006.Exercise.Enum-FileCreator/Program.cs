using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P006.Exercise.Enum_FileCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var directory = @"C:\Users\T460SU\Desktop";

            //get the enum languages name 
            var enumName = nameof(Languages);
            var pathParentDir = Path.Combine(directory, enumName);
            if (!Directory.Exists(pathParentDir))
            {
                Directory.CreateDirectory(pathParentDir);
                WriteLine($"{pathParentDir} Created", ConsoleColor.Green);
            }
            else
            {
                WriteLine($"{pathParentDir} Exists, not creating", ConsoleColor.Red);
            }

            //get the count of items in Languages enum
            var count = Enum.GetNames(typeof(Languages)).Length;

            for (int i = 0; i < count; i++)
            {
                //get language from enum
                var language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();

                //language dir
                var languageDir = Path.Combine(pathParentDir, language);
                if(!Directory.Exists(languageDir))
                {
                    Directory.CreateDirectory(languageDir);
                    WriteLine($"\t{languageDir} Created", ConsoleColor.Blue);
                }
                else
                {
                    WriteLine($"\t{languageDir}  Exists, not creating", ConsoleColor.Magenta);
                }

                //check that the log.txt exists or not
                var file = Path.Combine(languageDir, "log.txt");

                if(File.Exists(file))
                {
                    WriteLine($"\t\t{file}  Exists, not creating", ConsoleColor.Yellow);                   
                }
                else
                {
                    using (var sw = new StreamWriter(file, append: true))
                    {
                        sw.WriteLine($"File No {i+1} created on {DateTime.Now} for {language}");
                    }
                    WriteLine($"\t\t{file} Created", ConsoleColor.Cyan);
                }
            }
        }

        static void WriteLine(string message, ConsoleColor? color)
        {
            var defaultColor = Console.ForegroundColor;
            if(color != null)
            {
                Console.ForegroundColor = color.GetValueOrDefault();
            }
            Console.WriteLine(message);
            if(color != null)
            {
                Console.ForegroundColor = defaultColor;
            }
        }
    }

    enum Languages
    {
        English,
        French,
        Arabic,
        Turkish,
        Farsi,
        Urdu
    }
}
