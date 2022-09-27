<Query Kind="Statements" />

Expression<Func<int, int, int>> adder = (x, y) => x + y;
var executableAdder = adder.Compile(); // compile to delegate
Console.WriteLine(executableAdder(2,3)); // call delegate