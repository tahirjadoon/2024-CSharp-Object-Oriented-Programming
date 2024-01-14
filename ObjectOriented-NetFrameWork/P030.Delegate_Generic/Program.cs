using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P030.Delegate_Generic
{
    public delegate T DisplayInfoDelegate<T>(T value);

    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayInfoDelegate<int> myNumber = new DisplayInfoDelegate<int>(DisplayValue);
            Console.WriteLine(myNumber(100));

            DisplayInfoDelegate<double> myDoubleNumber = new DisplayInfoDelegate<double>(DisplayValue);
            Console.WriteLine(myDoubleNumber(3.5));

            DisplayInfoDelegate<DateTime> myDate = new DisplayInfoDelegate<DateTime>(DisplayValue);
            Console.WriteLine(myDate(new DateTime(2010, 2, 28)));
        }

        public static T DisplayValue<T>(T value)
        {
            Console.WriteLine("Now we are accessing variable of type " + value.GetType().Name);
            return value;
        }
    }
}
