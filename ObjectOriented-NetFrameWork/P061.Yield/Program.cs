using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P061.Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in PerformMathOperation(3,2))
            {
                Console.WriteLine(item);
            }
        }

        public static IEnumerable<double> PerformMathOperation(int one, int two)
        {
            yield return one + two;
            yield return one - two;
            yield return one * two;
            yield return Math.Round(((double)one / (double)two), 2);
        }
    }
}
