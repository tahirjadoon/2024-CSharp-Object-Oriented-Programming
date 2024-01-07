using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P003.Abstraction
{
    abstract class Shape
    {
        public abstract void Draw();

        public void SayHi()
        {
            Console.WriteLine("Hi from the abstract class");
        }
    }
}
