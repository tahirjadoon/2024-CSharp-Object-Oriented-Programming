
#define underDev

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P060.Preprocessor_Directives
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Block
            var x = 20;
            Console.WriteLine($"Firts region: {x}");
            #endregion First end

#if (underDev)
            Console.WriteLine($"This app is under development");
#else
            Console.WriteLine($"This app is live");
#endif
        }
    }
}
