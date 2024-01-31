// See https://aka.ms/new-console-template for more information
using OOP.DotNetCore.Core;

using var resource = new Resource();
resource.Use();

ConsoleHelper.WriteLine("This app is awesome", ConsoleColor.Cyan);

Console.ReadLine();


class Resource: IDisposable
{
    public void Use() => ConsoleHelper.WriteLine("Using resource...", ConsoleColor.Yellow);

    public void Dispose() => ConsoleHelper.WriteLine("Disposing resource", ConsoleColor.Red);
}