// See https://aka.ms/new-console-template for more information

var cities = new string[] {
            "New York", // 0 - 5
            "Vienna",   // 1 - 4
            "Madrid",   // 2 - 3
            "London",   // 3 - 2
            "Cairo"     // 4 - 1
            };

Console.WriteLine($"With cities.Length - 1 : {cities[cities.Length - 1]}");
Console.WriteLine($"With ^1 means cities.Length - 1 : {cities[^1]}");

List<int> numbers = new List<int>();
numbers.Add(0);
numbers.Add(1);
numbers.Add(4);
numbers.Add(5);

Console.WriteLine($"With ^2 means numbers.Length - 2 : {numbers[^2]}");