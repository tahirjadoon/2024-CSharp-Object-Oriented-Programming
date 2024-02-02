// See https://aka.ms/new-console-template for more information


using OOP.DotNetCore.Core;


Console.WriteLine("Getting products and printing - reguar");
var products = GetProducts();
foreach (var product in products)
{
    ConsoleHelper.WriteLine($"\t{product}", ConsoleColor.Yellow);
}

Console.WriteLine("Getting products and printing - async");
await foreach (var item in GetProductsAsync())
{
    ConsoleHelper.WriteLine($"\t{item}", ConsoleColor.Cyan);
}


Console.WriteLine("Hit enter to exit");
Console.ReadLine();

static IEnumerable<string> GetProducts()
{
    yield return "Getting Products...";
    yield return "Product 1";
    yield return "Product 2";
    yield return "Product 3";
}

static async IAsyncEnumerable<string> GetProductsAsync()
{
    yield return "Getting Products...";
    await Task.Delay(1000);
    yield return "Product 1";
    await Task.Delay(1000);
    yield return "Product 2";
    await Task.Delay(1000);
    yield return "Product 3";
    await Task.Delay(1000);
}