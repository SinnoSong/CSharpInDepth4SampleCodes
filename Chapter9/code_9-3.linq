<Query Kind="Statements" />

decimal price = 95.25m;
decimal tip = price * 0.2m;
Console.WriteLine($"Price: {price,9:C}");
Console.WriteLine($"Tip:   {tip,9:C}");
Console.WriteLine($"Total: {price + tip,9:C}");