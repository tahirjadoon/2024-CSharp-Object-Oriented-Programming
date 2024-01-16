using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040.Events_More
{
    public class Football
    {
        private DisplayInformation displayInfoInstance;

        public Football()
        {
            displayInfoInstance = new DisplayInformation();

            displayInfoInstance.DisplayDateAfterEvent += DisplayInformation_DisplayDateAfterEvent;
            displayInfoInstance.DisplayMessageBeforeEvent += DisplayInfoInstance_DisplayMessageBeforeEvent;
        }

        private void DisplayInfoInstance_DisplayMessageBeforeEvent()
        {
            ConsoleHelper.WriteLine($"Football => About to display information", ConsoleColor.Green);
        }

        private void DisplayInformation_DisplayDateAfterEvent()
        {
            ConsoleHelper.WriteLine($"Football => Info has been displayed on {DateTime.Now.ToShortTimeString()}", ConsoleColor.Cyan);
        }

        public void DisplayClub(string club, string country)
        {
            displayInfoInstance.DisplayClub(club, country);
        }

        public void DisplayPlayerInformation(string name, string club)
        {
            displayInfoInstance.DisplayPlayer(name, club);
        }
    }
}
