using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Shape();
            shapes[1] = new Circle();
            shapes[2] = new Line();
            shapes[3] = new Triangle();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
