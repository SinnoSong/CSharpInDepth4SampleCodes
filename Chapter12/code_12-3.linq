<Query Kind="Statements" />

static (int x, int y, string text) MethodReturningTuple() => (1, 2, "t");

int a = 20;
int b = 30;
string name = "before";
Console.WriteLine($"a:{a}; b: {b}; name :{name}");
(a, b, name) = MethodReturningTuple();
Console.WriteLine($"a:{a}; b: {b}; name :{name}");