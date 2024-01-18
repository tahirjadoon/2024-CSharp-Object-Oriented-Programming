using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P046.Monitor_Class
{
    //also check Deadlocks_Lock_Keyword project
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
    }

    class Files
    {

        public void Write(object path)
        {
            Monitor.Enter(path);
            try
            {
                Console.WriteLine($"Write in {path}");
                Thread.Sleep(2000);
                Console.WriteLine("Writing process has been completed\n");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        public void Read(object path)
        {
            Monitor.Enter(path);
            try
            {
                Console.WriteLine($"Read from {path}");
                Thread.Sleep(2000);
                Console.WriteLine("Reading process has been completed\n");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }
    }
}
