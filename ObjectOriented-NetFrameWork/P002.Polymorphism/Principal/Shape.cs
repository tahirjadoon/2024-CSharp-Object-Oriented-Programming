using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P002.Polymorphism
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a simple shape");
        }
    }
}
