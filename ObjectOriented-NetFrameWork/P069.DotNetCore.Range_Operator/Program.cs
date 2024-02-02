// See https://aka.ms/new-console-template for more information

var cities = new string[] {
                "New york", //0 - 6
                "Vienna",   //1 - 5
                "Madrid",   //2 - 4
                "London",   //3 - 3
                "Cairo",    //4 - 2  
                "Tokyo"     //5 - 1
            };

Console.WriteLine("\tCity\t\tIndex\tOver");
var index = 0;
foreach (var city in cities)
{
    if(index == 0)
        Console.WriteLine($"\t{city}\t{index}\t{cities.Length-index}");
    else
        Console.WriteLine($"\t{city}\t\t{index}\t{cities.Length - index}");
    index += 1;
}
Console.WriteLine("\n-----\n");

Console.WriteLine("Working with range");
var copyCities = cities[0..5];
Console.WriteLine($"\tcities[0..5]\t\tLength={copyCities.Length}\t{string.Join(", ", copyCities)}");

var copyCities2 = cities[^5..^2];
Console.WriteLine($"\tcities[^5..^2]\t\tLength={copyCities2.Length}\t{string.Join(", ", copyCities2)}");

var copyCities3 = cities[^5..^4];
Console.WriteLine($"\tcities[^5..^4]\t\tLength={copyCities3.Length}\t{string.Join(", ", copyCities3)}");

var copyCities4 = cities[..];
Console.WriteLine($"\tcities[..]\t\tLength={copyCities4.Length}\t{string.Join(", ", copyCities4)}");

var copyCities5 = cities[..3];
Console.WriteLine($"\tcities[..3]\t\tLength={copyCities5.Length}\t{string.Join(", ", copyCities5)}");

var copyCities6 = cities[1..];
Console.WriteLine($"\tcities[1..]\t\tLength={copyCities6.Length}\t{string.Join(", ", copyCities6)}");

var copyCities7 = cities[1..3];
Console.WriteLine($"\tcities[1..3]\t\tLength={copyCities7.Length}\t{string.Join(", ", copyCities7)}");

Console.WriteLine("\n-----\n");

Range citiesRange = 0..5;
Console.WriteLine(citiesRange.GetType());
Console.WriteLine(citiesRange.Start);
Console.WriteLine(citiesRange.End);

var listOfCities = cities[citiesRange];
foreach (var newCity in listOfCities)
{
    Console.WriteLine(newCity);
}

Console.ReadLine();
