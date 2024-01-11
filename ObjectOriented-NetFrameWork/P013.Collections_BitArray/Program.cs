using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P013.Collections_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //place holder bool array
            ConsoleHelper.WriteLine("BoolArray : Creating and setting boolArray with 4 items");
            bool[] boolArray = new bool[4] { false, false, false, true };
            PrintBoolArray(boolArray);

            //create bitArray from boolArray
            ConsoleHelper.WriteLine("FirstBitArray : Creating bit array from boolArray");
            BitArray firstBitArray = new BitArray(boolArray);
            PrintBitArray(firstBitArray);

            //create empty bit array
            ConsoleHelper.WriteLine("SecondBitArray : Creating bit array manually and setting its values");
            BitArray secondBitArray = new BitArray(4);
            secondBitArray.Set(0, false);
            secondBitArray.Set(1, false);
            secondBitArray.Set(2, true);
            secondBitArray.Set(3, true);
            PrintBitArray(secondBitArray);

            
            //Joing the firstBitArray and secondBitArray with AND. 
            ConsoleHelper.WriteLine("FirstBitArray AND SecondBitArray - Joing the firstBitArray and secondBitArray with AND. Displaying AND result");
            ConsoleHelper.WriteLine("\t Overwrites FirstBitArray as well");
            var andResult = firstBitArray.And(secondBitArray);
            PrintBitArray(andResult);

            //Joing the firstBitArray and secondBitArray with OR. 
            ConsoleHelper.WriteLine("FirstBitArray OR SecondBitArray - Joing the firstBitArray and secondBitArray with OR. Displaying OR result");
            ConsoleHelper.WriteLine("\t Overwrites FirstBitArray as well");
            var orResult = firstBitArray.Or(secondBitArray);
            PrintBitArray(orResult);
            

            //Joing the firstBitArray and secondBitArray with NOT. 
            ConsoleHelper.WriteLine("FirstBitArray NOT - Not will revese the values of the bitArray");
            ConsoleHelper.WriteLine("\tFirstBitArray BEFORE", ConsoleColor.Cyan);
            PrintBitArray(firstBitArray);
            var notResult = firstBitArray.Not();
            ConsoleHelper.WriteLine("\tRESULT OF firstBitArray.Not", ConsoleColor.Cyan);
            PrintBitArray(notResult);
        }

        static void PrintBoolArray(bool[] array)
        {
            foreach(var a in array)
            {
                if (a)
                {
                    ConsoleHelper.WriteLine(a.ToString(), ConsoleColor.Green);
                }
                else
                {
                    ConsoleHelper.WriteLine(a.ToString(), ConsoleColor.Yellow);
                }
                
            }
        }

        static void PrintBitArray(BitArray array)
        {
            foreach(var item in array)
            {
                if (Convert.ToBoolean(item))
                {
                    ConsoleHelper.WriteLine(item.ToString(), ConsoleColor.Green);
                }
                else
                {
                    ConsoleHelper.WriteLine(item.ToString(), ConsoleColor.Yellow);
                }
                
            }
        }
    }
}
