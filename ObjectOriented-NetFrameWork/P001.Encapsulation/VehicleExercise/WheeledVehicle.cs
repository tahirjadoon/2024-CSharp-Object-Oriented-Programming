using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    class WheeledVehicle : Vehicle
    {
        private string _color;
        private decimal _price;

        public string Color { get { return _color; } set { _color = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }

        public void ChangeColor()
        {
            Console.WriteLine("Color is changing... Color has changed - WheeledVehicle");
        }
    }
}
