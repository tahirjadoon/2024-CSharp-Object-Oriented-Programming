using OOP.Core;
using P007.Exercise.CaesarCipher.Exercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P007.Exercise.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plainText = "I am string";

            var encrypted = CaesaerCipher.Encrypt(plainText);

            var decrypted = CaesaerCipher.Decrypt(encrypted);

            ConsoleHelper.WriteLine($"Plain text: {plainText}", ConsoleColor.Green);
            ConsoleHelper.WriteLine($"Encrypted text: {encrypted}", ConsoleColor.Yellow);
            ConsoleHelper.WriteLine($"Decrypted text: {decrypted}", ConsoleColor.Magenta);
        }
    }
}
