using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P037.Delegate_Action_AnnonMethod_LambExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jack";

            //action
            Action<string> message = ShowMessage;
            message(name);

            //Annonymous method
            Action<string> anonymousMethod = delegate (string inName) { Console.WriteLine($"Hi, how are you today '{inName}'? I am anonymousMethod"); };
            anonymousMethod(name);

            //lambda Expression
            Action<string> lambdaExpression = inName => { Console.WriteLine($"Hi, how are you today '{inName}'? I am lambda expression"); };
            lambdaExpression(name);
        }

        /// <summary>
        /// Show message receives name and displays message
        /// </summary>
        /// <param name="name"></param>
        public static void ShowMessage(string name) => Console.WriteLine($"Hi, how are you today {name}? I am action");
    }
}
