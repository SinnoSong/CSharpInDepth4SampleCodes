<Query Kind="Statements" />

var tuple = (10, "text");
var (a, b) = tuple;
(int c, string d) = tuple;

int e;
string f;
(e, f) = tuple;

Console.WriteLine($"a: {a}; b: {b}");
Console.WriteLine($"c: {c}; d: {d}");
Console.WriteLine($"e: {e}; f: {f}");