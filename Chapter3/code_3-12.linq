<Query Kind="Statements" />

Expression<Func<int, int, int>> adder = (x, y) => x + y;
Console.WriteLine(adder);