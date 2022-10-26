<Query Kind="Statements" />

string value = "Before";
FormattableString formattable = $"Current value:{value}";
Console.WriteLine(formattable);
value ="After";
Console.WriteLine(formattable);