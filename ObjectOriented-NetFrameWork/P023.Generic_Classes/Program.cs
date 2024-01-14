using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P023.Generic_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayBuilding<int>(null);

            var empireState = new Building<long>
            {
                Name = "Empire State",
                City = "New York",
                Height = 443,
                Weight = 365000
            };
            DisplayBuilding(empireState, ConsoleColor.Yellow);

            var burjKhalifa = new Building<double>
            {
                Name = "Burj Khalifa",
                City = "Dubai",
                Height = 830,
                Weight = 450000
            };
            DisplayBuilding(burjKhalifa, ConsoleColor.Green);

            var eifelTower = new Building<float>
            {
                Name = "Eiferl Tower",
                City = "Paris",
                Height = 324f,
                Weight = 7300f
            };
            DisplayBuilding(eifelTower, ConsoleColor.Cyan);
        }

        static void DisplayBuilding<T>(Building<T> building, ConsoleColor? color = null)
        {
            if(building == null)
            {
                ConsoleHelper.WriteLine("Building is null", ConsoleColor.Red);
                return;
            }

            ConsoleHelper.WriteLine($"Name: {building.Name}, City: {building.City}, Height: {building.Height}, Weight: {building.Weight} ", color);
        }
    }
}
