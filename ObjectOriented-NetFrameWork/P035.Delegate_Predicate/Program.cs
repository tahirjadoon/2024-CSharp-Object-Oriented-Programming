using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035.Delegate_Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> condition = IsAdmin;
            Console.WriteLine("Is emp 11 admin: " + condition(11));
            Console.WriteLine("Is emp 10 admin: " + condition(10));
        }

        /// <summary>
        /// returns true when empNo = 10
        /// </summary>
        /// <param name="empNo"></param>
        /// <returns></returns>
        public static bool IsAdmin(int empNo) => empNo == 10;
    }
}
