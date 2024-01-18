using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P044.Deadlocks_Lock_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Files file = new Files();
            Thread[] threads = new Thread[10];

            for (int i = 0; i < 10; i++) 
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\accounts{i}.txt");
            }
        }

        class Files
        {
            public object fileLock = new object();

            public void Write(object path)
            {
                lock (fileLock)
                {
                    Console.WriteLine($"Write in {path}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Writing process has been completed\n");
                }
            }

            public void Read(object path)
            {
                lock (fileLock)
                {
                    Console.WriteLine($"Read from {path}");
                    Thread.Sleep(2000);
                    Console.WriteLine("Reading process has been completed\n");
                }
            }
        }
    }
}
