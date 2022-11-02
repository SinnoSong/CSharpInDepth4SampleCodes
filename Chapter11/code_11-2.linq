<Query Kind="Statements" />

var tuple = (x:5,10);
Console.WriteLine(tuple.x);
Console.WriteLine(tuple.Item1);
Console.WriteLine(tuple.Item2);

tuple.x = 100;
Console.WriteLine(tuple.Item1);