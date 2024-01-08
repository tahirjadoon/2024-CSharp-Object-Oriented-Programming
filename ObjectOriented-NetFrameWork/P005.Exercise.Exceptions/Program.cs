using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P005.Exercise.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int divResult = 0;

            Console.WriteLine("Enter the numbers to divide them...");
            Console.WriteLine();

            var index = 1;
            var isKeepRuning = true;

            while (isKeepRuning)
            {
                try
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"Division run {index}");
                    Console.WriteLine("----------------------");

                    var isFirstNumber = GetNumber("Enter the first number", out firstNumber);
                    var isSecondNumber = GetNumber("Enter the second number", out secondNumber);

                    divResult = PerformDivision(firstNumber, secondNumber);

                    Console.WriteLine($"Result = {divResult}");

                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Cannot divide by 0. Exception message {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Invalid input. Exception message {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"General exception. Exception message {ex.Message}");
                }
                finally
                {
                    Console.WriteLine();
                    Console.WriteLine("Do you want to keep executing? Y/y=Yes");
                    string continueInput = Console.ReadLine();

                    isKeepRuning = continueInput.ToLower() == "y" || continueInput.ToLower() == "yes";
                    index++;
                    Console.WriteLine();
                }
            }

            
        }

        static bool GetNumber(string title, out int numberEntered)
        {
            Console.WriteLine(title);
            numberEntered = int.Parse(Console.ReadLine());
            return true;
        }

        static int PerformDivision(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
