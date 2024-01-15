using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P036.Delegate_Func_AnnonMethod_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "jack sparrow";

            //Func
            Func<string, string> convertToUpperCase = UpperCaseString;
            Console.WriteLine($"With Func changing '{text}' = " + convertToUpperCase(text));

            //Annonymous Method
            Func<string, string> annonmyousMethod = delegate (string myName) { return myName.ToUpper(); };
            Console.WriteLine($"With AnnonmyousMethod changing '{text}' = " + annonmyousMethod(text));

            //Lambda Expression
            Func<string, string> lambdaExpression = intext => intext.ToUpper();
            Console.WriteLine($"With LambdaExpression changing '{text}' = " + lambdaExpression(text));
        }

        /// <summary>
        /// Converts the input to upper case
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string UpperCaseString(string input) => input.ToUpper();
    }
}
