// See https://aka.ms/new-console-template for more information

using OOP.DotNetCore.Core;

ICar f1 = new Ferrari();
f1.Start();
f1.Run();
f1.Run(45);

ConsoleHelper.WriteLine("\n---------\n", ConsoleColor.Red);

var f2 = new Ferrari();
((ICar)f2).Start();
f2.Run();
((ICar)f2).Run(55);

Console.ReadLine();

class Ferrari : ICar
{
    public void Run()
    {
        Console.WriteLine("Car is running");
    }
}

/// <summary>
/// ICar interface with default methods
/// </summary>
interface ICar
{
    public void Start() => Console.WriteLine("Car has started");

    public void Run();

    public void Run(double speed) => Console.WriteLine($"Car is running at {speed}");
}