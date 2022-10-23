<Query Kind="Statements" />

decimal price = 95.25m;
decimal tip = price * 0.2m;
Console.WriteLine("Price : {0,9:C}", price);
Console.WriteLine("Tip : {0,9:C}", tip);
Console.WriteLine("Total : {0,9:C}", price + tip);