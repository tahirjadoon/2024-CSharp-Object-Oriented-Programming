using OOP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P049.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example1 - simple
            Task task1 = new Task(new Action(Task1));
            task1.Start();

            //exampe2 - delegate
            Task task2 = new Task(delegate () {
                Task2();
            });
            task2.Start();

            //example3 - lambda
            Task task3 = new Task(() =>
            {
                Task3();
            });
            task3.Start();

            //example4
            Task task4 = Task.Run(() =>
            {
                Task4();
            });

            //example5 passing params to the metod - simple
            Task task5 = new Task(new Action<object>(GenericTask), new GenericClass(5, ConsoleColor.DarkYellow));
            task5.Start();

            //example6 passing params to the metod - delegate
            Task task6 = new Task(delegate (object info) {
                GenericTask(info);
            }, new GenericClass(6, ConsoleColor.DarkGreen));
            task6.Start();

            //example3 passing params to the metod - lambda
            Task task7 = new Task(i =>
            {
                GenericTask(i);
            }, new GenericClass(7, ConsoleColor.DarkCyan));
            task7.Start();

            //example8 passing params to the metod
            Task task8 = Task.Run(() =>
            {
                GenericTask(new GenericClass(8, ConsoleColor.DarkBlue));
            });

            ConsoleHelper.WriteLineLock("What is your name: ", ConsoleColor.Magenta);
            var name = Console.ReadLine();
            ConsoleHelper.WriteLineLock($"Your name is {name}", ConsoleColor.Magenta);

            Console.ReadLine();
        }

        static void Task1()
        {
            ConsoleHelper.WriteLineLock("Task 1 is starting", ConsoleColor.Yellow);
            ConsoleHelper.WriteLineLock("Task 1 is running", ConsoleColor.Yellow);
            Thread.Sleep(5000);
            ConsoleHelper.WriteLineLock("Task 1 is complete", ConsoleColor.Yellow);
        }

        static void Task2()
        {
            ConsoleHelper.WriteLineLock("Task 2 is starting", ConsoleColor.Green);
            ConsoleHelper.WriteLineLock("Task 2 is running", ConsoleColor.Green);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLineLock("Task 2 is complete", ConsoleColor.Green);
        }

        static void Task3()
        {
            ConsoleHelper.WriteLineLock("Task 3 is starting", ConsoleColor.Cyan);
            ConsoleHelper.WriteLineLock("Task 3 is running", ConsoleColor.Cyan);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLineLock("Task 3 is complete", ConsoleColor.Cyan);
        }

        static void Task4()
        {
            ConsoleHelper.WriteLineLock("Task 4 is starting", ConsoleColor.Blue);
            ConsoleHelper.WriteLineLock("Task 4 is running", ConsoleColor.Blue);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLineLock("Task 4 is complete", ConsoleColor.Blue);
        }

        static void GenericTask(object info)
        {
            var getit = info as GenericClass;
            ConsoleHelper.WriteLineLock($"Task {getit.Number} is starting - with params - color {getit.Color.ToString()}", getit.Color);
            ConsoleHelper.WriteLineLock($"Task {getit.Number} is running - with params - color {getit.Color.ToString()}", getit.Color);
            Thread.Sleep(2000);
            ConsoleHelper.WriteLineLock($"Task {getit.Number} is complete - with params - color {getit.Color.ToString()}", getit.Color);
        }

        public class GenericClass
        {
            private int _number;
            private ConsoleColor _color;
            private string _colorName;

            public GenericClass(int number, ConsoleColor color)
            {
                _number = number;
                _color = color;
            }

            public int Number => _number;
            public ConsoleColor Color => _color;
        }
    }
}
