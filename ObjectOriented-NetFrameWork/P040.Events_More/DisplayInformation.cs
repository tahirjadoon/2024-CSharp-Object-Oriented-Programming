using OOP.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040.Events_More
{
    public class DisplayInformation
    {
        public delegate void DisplayDateAfterDelegate();
        public delegate void DisplayMessageBeforeDelegate();

        public event DisplayDateAfterDelegate DisplayDateAfterEvent;
        public event DisplayMessageBeforeDelegate DisplayMessageBeforeEvent;

        public void DisplayClub(string clubName, string country)
        {
            DisplayMessageBeforeEvent();
            ConsoleHelper.WriteLine($"DisplayClub => ClubName: {clubName}, Country: {country}", ConsoleColor.Yellow);
            DisplayDateAfterEvent();
            Console.WriteLine();
        }

        public void DisplayPlayer(string playerName, string clubName)
        {
            DisplayMessageBeforeEvent();
            ConsoleHelper.WriteLine($"DisplayPlayer => PlayerName: {playerName}, ClubName: {clubName}", ConsoleColor.Yellow);
            DisplayDateAfterEvent();
        }
    }
}
