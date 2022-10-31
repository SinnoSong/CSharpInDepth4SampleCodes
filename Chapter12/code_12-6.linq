<Query Kind="Statements" />

StringBuilder builder = new StringBuilder("12345");
StringBuilder original = builder;

StringBuilder targetForLength = builder;

(StringBuilder, int) tuple = (new StringBuilder("67890"), 3);

builder = tuple.Item1;
targetForLength.Length = tuple.Item2;

Console.WriteLine(original);
Console.WriteLine(builder);