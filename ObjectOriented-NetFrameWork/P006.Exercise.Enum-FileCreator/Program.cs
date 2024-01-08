using OOP.Core;
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
                ConsoleHelper.WriteLine($"{pathParentDir} Created", ConsoleColor.Green);
            }
            else
            {
                ConsoleHelper.WriteLine($"{pathParentDir} Exists, not creating", ConsoleColor.Red);
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
                    ConsoleHelper.WriteLine($"\t{languageDir} Created", ConsoleColor.Blue);
                }
                else
                {
                    ConsoleHelper.WriteLine($"\t{languageDir}  Exists, not creating", ConsoleColor.Magenta);
                }

                //check that the log.txt exists or not
                var file = Path.Combine(languageDir, "log.txt");

                if(File.Exists(file))
                {
                    ConsoleHelper.WriteLine($"\t\t{file}  Exists, not creating", ConsoleColor.Yellow);                   
                }
                else
                {
                    using (var sw = new StreamWriter(file, append: true))
                    {
                        sw.WriteLine($"File No {i+1} created on {DateTime.Now} for {language}");
                    }
                    ConsoleHelper.WriteLine($"\t\t{file} Created", ConsoleColor.Cyan);
                }
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
