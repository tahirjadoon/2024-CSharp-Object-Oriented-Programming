using OOP.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P014.Exercise.Struct_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals dog = new Animals { Name = "Max" };

            Animals cat = new Animals { Name = "Lucy" };

            Animals elephant = new Animals() { Name = "Fofy" };

            Trainers john = new Trainers() { TrainerName = "John Jackson" };

            ArrayList list = new ArrayList();
            list.Add(dog);
            list.Add(cat);
            list.Add(elephant);
            list.Add(john);

            ConsoleHelper.WriteLine("Checking and Casting #1 ");
            foreach (var item in list)
            {
                if (typeof(Animals) == item.GetType())
                {
                    ((Animals)item).SayHi();
                    ((Animals)item).Feed();
                }
                else
                {
                    ((Trainers)item).SayHi();
                }
            }

            ConsoleHelper.WriteLine("\n\nChecking and Casting #2 ");
            foreach (var item in list)
            {
                if (item is Animals a)
                {
                    a.SayHi();
                    a.Feed();
                }
                else if(item is Trainers t)
                {
                    t.SayHi();
                }
                else
                {
                    ConsoleHelper.WriteLine("\tInvalid type", ConsoleColor.Red);
                }
            }
        }
    }

    struct Animals
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SayHi()
        {
            ConsoleHelper.WriteLine("Hello my name is " + name, ConsoleColor.Yellow);
        }

        public void Feed()
        {
            ConsoleHelper.WriteLine(name + " is now eating", ConsoleColor.Cyan);
        }

    }

    struct Trainers
    {
        private string trainerName;
        public string TrainerName
        {
            get { return trainerName; }
            set { trainerName = value; }
        }

        public void SayHi()
        {
            ConsoleHelper.WriteLine("Hello I am the new trainer", ConsoleColor.Magenta);
        }

    }
}
