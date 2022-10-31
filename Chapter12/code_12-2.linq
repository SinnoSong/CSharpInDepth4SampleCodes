<Query Kind="Statements" />

static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

(int a, int b, string name) = MethodReturningTuple();
Console.WriteLine($"a:{a};b:{b};name:{name}");