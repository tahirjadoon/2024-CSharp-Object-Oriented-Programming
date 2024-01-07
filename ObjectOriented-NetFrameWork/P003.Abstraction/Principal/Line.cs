using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P003.Abstraction.Principal
{
    internal class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Hi from the draw method in line class");
        }
    }
}
