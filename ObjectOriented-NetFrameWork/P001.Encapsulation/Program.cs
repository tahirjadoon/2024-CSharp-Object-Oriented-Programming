using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourWheeledVehicle car = new FourWheeledVehicle();
            car.MyVehicle(); // metod in Vehicle, WheeledVehicle derives from it
            car.ChangeColor(); //method in WheeledVehicle, FourWheeledVehicle derives from it
            car.StartVehicle();
            car.RunAtFullSpeed();
        }
    }
}
