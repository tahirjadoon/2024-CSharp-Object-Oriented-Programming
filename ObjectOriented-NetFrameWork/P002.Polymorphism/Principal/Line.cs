using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002.Polymorphism
{
    class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am a simple line");
        }
    }
}
