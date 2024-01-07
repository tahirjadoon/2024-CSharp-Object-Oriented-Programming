using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002.Polymorphism
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am a simple circle");
        }
    }
}
