using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P043.Parameterized_Threadstart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(15);
        }

        class Helper
        {
            public void Loop(object number)
            {
                for (int i = 0; i<(int)number; i++)
                {
                    ConsoleHelper.WriteLine(((int)i).ToString(), ConsoleColor.Yellow);
                }
            }
        }
    }
}
