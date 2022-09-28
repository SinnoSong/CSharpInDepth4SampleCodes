<Query Kind="Statements" />

dynamic text = "hello world";
string world = text.Substring(6);
Console.WriteLine(world);

string broken = text.SUBSTR(6);
Console.WriteLine(broken);