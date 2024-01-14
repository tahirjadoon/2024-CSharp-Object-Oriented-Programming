using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P032.Deleagte_Anonymous_LambdaExmp
{
    delegate void DisplayMsgDelegate();
    delegate int MultiplyDelegate(int n);

    internal class Program
    {
        static void Main(string[] args)
        {
            //MultiplyDelegate multiplyNum = delegate (int n) { { return n * 3; } };
            MultiplyDelegate multiplyNum = n => n * 3;
            Console.WriteLine(multiplyNum(30));

            //DisplayMsgDelegate message = delegate { Console.WriteLine("Hi from the anonymous method"); };
            DisplayMsgDelegate message = () => { Console.WriteLine("Hi from the anonymous method"); };
            message();
        }
    }
}
