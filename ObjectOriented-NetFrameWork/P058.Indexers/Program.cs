using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058.Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animals = new Animal();
            animals[0] = "Dog";
            animals[1] = "Tiger";
            animals[2] = "Horse";
            Console.WriteLine(animals[1]);
        }

        class Animal
        {
            private string[] name = new string[100];

            public string this[int index]
            {
                get { return name[index]; }
                set { name[index] = value; }
            }
        }
    }
}
