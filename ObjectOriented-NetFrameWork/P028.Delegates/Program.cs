using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P028.Delegates
{
    // void delegate with no argument
    public delegate void PlayerInfoDelegate();

    // void delegate with one string argument
    public delegate void PlayerInfoWithNameDelegate(string playerName);

    // void delegate with one string argument and one int
    public delegate void PlayerInfoNameWithGoalsDelegate(string name, int goals);

    // string delegate with one int argument 
    public delegate string PlayerBasedOnNumberDelegate(int number);

    //print info with params delegate
    public delegate void PrintInfoWithParamsDelegate(string key, params KeyValuePair<string, object>[] args);

    //print info with dictionary delegate
    public delegate void DisplayPalyerDicDelegate(Dictionary<int, string> players);

    internal class Program
    {

        static void Main(string[] args)
        {
            ConsoleHelper.WriteLine("ronaldinho - No argument passed with and without .Invoke", ConsoleColor.Yellow);
            PlayerInfoDelegate ronaldinho = new PlayerInfoDelegate(DisplayInformation);
            ronaldinho.Invoke();
            ronaldinho();

            ConsoleHelper.WriteLine("\n\nplayerName - With name param", ConsoleColor.Yellow);
            PlayerInfoWithNameDelegate playerName = new PlayerInfoWithNameDelegate(DisplayInformation);
            playerName("Messi");

            ConsoleHelper.WriteLine("\n\nnewPlayer - With name and goal param", ConsoleColor.Yellow);
            PlayerInfoNameWithGoalsDelegate newPlayer = new PlayerInfoNameWithGoalsDelegate(DisplayInformation);
            newPlayer("Ronaldo", 60);
            newPlayer("Rooney", 25);

            ConsoleHelper.WriteLine("\n\nnumber - With id only", ConsoleColor.Yellow);
            PlayerBasedOnNumberDelegate number = new PlayerBasedOnNumberDelegate(DisplayInformation);
            Console.WriteLine(number(8));
            Console.WriteLine(number(10));


            ConsoleHelper.WriteLine("\n\nGetting method info", ConsoleColor.Yellow);
            PrintInfoWithParamsDelegate printMethodInfo = new PrintInfoWithParamsDelegate(PrintInfoWithParams);
            printMethodInfo(string.Empty,
                                new KeyValuePair<string, object>("ronaldinho", ronaldinho.Method),
                                new KeyValuePair<string, object>("playerName", playerName.Method),
                                new KeyValuePair<string, object>("newPlayer", newPlayer.Method),
                                new KeyValuePair<string, object>("number", number.Method)
                           );

            
            ConsoleHelper.WriteLine("\n\nGetting parameters info - newPlayer", ConsoleColor.Yellow);
            foreach (var item in newPlayer.Method.GetParameters())
            {
                PrintInfoWithParamsDelegate printParamInfo = new PrintInfoWithParamsDelegate(PrintInfoWithParams);
                printParamInfo(item.Name,
                    new KeyValuePair<string, object>("ItemName", item.Name),
                    new KeyValuePair<string, object>("ParameterType", item.ParameterType),
                    new KeyValuePair<string, object>("TypeName", item.ParameterType.Name),
                    new KeyValuePair<string, object>("Position", item.Position),
                    new KeyValuePair<string, object>("IsOptional", item.IsOptional),
                    new KeyValuePair<string, object>("DefaultValueWhenOptional", item.DefaultValue)
                    );

            }

            ConsoleHelper.WriteLine("\n\nDisplay Players from Dictionary", ConsoleColor.Yellow);
            Dictionary<int, string> listPlayers = new Dictionary<int, string>
            {
                {7, "Ronoldo" },
                {10, "Messie" },
                {8, "Iniesta" }
            };
            DisplayPalyerDicDelegate players = new DisplayPalyerDicDelegate(DisplayPlayersInfo);
            players(listPlayers);
        }

        public static void DisplayPlayersInfo(Dictionary<int, string> players)
        {
            var index = 1;
            foreach (var item in players)
            {
                ConsoleHelper.WriteLine($"\tPlayers: {1} PlayersNo: {item.Key}, PlayerName: {item.Value}");
                index++;
            }
        }

        public static void PrintInfoWithParams(string key, params KeyValuePair<string, object>[] args)
        {
            var tab = "\t";
            if (!string.IsNullOrWhiteSpace(key))
            {
                ConsoleHelper.WriteLine(tab + key, ConsoleColor.Green);
                tab += "\t";
            }
            
            foreach (var item in args)
            {
                Console.WriteLine($"{tab}{item.Key} = {item.Value}");
            }
        }

        public static void DisplayInformation()
        {
            Console.WriteLine("Information about player : Ronaldinho from brazil");
        }

        public static void DisplayInformation(string playerName)
        {
            Console.WriteLine("Information about player : " + playerName);
        }

        public static void DisplayInformation(string playerName, int goals)
        {
            Console.WriteLine("Information about player : " + playerName + " and he score " + goals + " goals");
        }

        public static string DisplayInformation(int number)
        {
            string playerName = string.Empty;
            switch (number)
            {
                case 7: playerName = "Ronaldo"; break;
                case 8: playerName = "Iniesta"; break;
                case 10: playerName = "Messi"; break;
                default: break;
            }
            return playerName;
        }
    }
}
