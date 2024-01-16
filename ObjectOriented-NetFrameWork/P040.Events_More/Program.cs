using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040.Events_More
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Football info = new Football();
            info.DisplayClub("Manchester United", "England");
            info.DisplayPlayerInformation("Ronoldo", "Real Madrid");
        }
    }
}
