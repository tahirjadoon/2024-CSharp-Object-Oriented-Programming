using P003.Abstraction.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P003.Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = new Line();

            line.SayHi();
            line.Draw();
        }
    }
}
