<Query Kind="Statements" />

StringBuilder builder = new StringBuilder("12345");
StringBuilder original = builder;

(builder, builder.Length) = (new StringBuilder("67890"), 3);

Console.WriteLine(original);
Console.WriteLine(builder);