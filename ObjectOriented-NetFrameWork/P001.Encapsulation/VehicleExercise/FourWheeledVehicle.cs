using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace P001.Encapsulation
{
    class FourWheeledVehicle : WheeledVehicle
    {
        private string _brandName;
        private int _capacity;

        public FourWheeledVehicle()
        {        
        }

        public string BrandName {  get { return _brandName; } set {  _brandName = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public void StartVehicle()
        {
            Console.WriteLine("Car has started - FourWheeledVehicle");
        }

        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running on full speed - FourWheeledVehicle");
        }


    }
}
