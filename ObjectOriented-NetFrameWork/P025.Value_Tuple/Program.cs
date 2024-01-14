using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P025.Value_Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Install-Package "System.ValueTuple"

            int x = 0;
            ConsoleHelper.WriteLine("Create #1");
            (int playerNo, string playerName, int playerGoals) ronaldo = (7, "Ronaldo", 55);
            PrintValueTuple(ronaldo);

            ConsoleHelper.WriteLine("\n\nCreate #2");
            var messi = (playerNo: 10, playerName: "Messi", playerGoals: 60);
            PrintValueTuple(messi);

            ConsoleHelper.WriteLine("\n\nNested Value Tuple");
            var ronaldoGoals = (Year2017: 64, Year2016: 60, Year2015: 50, Year2014: 55);
            var ronaldo2 = (playerNo: 7, playerName: "Ronaldo", playerGoals: ronaldoGoals);

            Console.WriteLine(ronaldo2.playerNo);
            Console.WriteLine(ronaldo2.playerName);
            Console.WriteLine(ronaldo2.playerGoals.Year2017);
            Console.WriteLine(ronaldo2.playerGoals.Year2016);
            Console.WriteLine(ronaldo2.playerGoals.Year2015);
            Console.WriteLine(ronaldo2.playerGoals.Year2014);

            ConsoleHelper.WriteLine("\n\nGetting Player Info from method");
            var info = GetPlayerInfo();
            PrintValueTuple(info);

            ConsoleHelper.WriteLine("\n\nValueTuple with list");
            var players = new List<(int playerNo, string playerName, int playerGoals)>();
            players.Add((7, "Ronaldo", 55));
            players.Add((10, "Messi", 60));
            players.Add((20, "Neymar", 55));

            foreach (var item in players)
            {
                PrintValueTuple(item, true);
            }
        }

        static void PrintValueTuple((int playerNo, string playerName, int playerGoals) data, bool isSingleLine = false)
        {
            if (!isSingleLine)
            {
                Console.WriteLine(data.playerNo);
                Console.WriteLine(data.playerName);
                Console.WriteLine(data.playerGoals);
                return;
            }
            Console.WriteLine($"{data.playerNo} - {data.playerName} - {data.playerGoals}");

        }


        public static (int, string, int) GetPlayerInfo()
        {
            var messi = (10, "Messi", 60);
            return messi;
        }
    }
}
