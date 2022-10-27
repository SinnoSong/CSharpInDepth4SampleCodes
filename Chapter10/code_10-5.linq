<Query Kind="Statements" />

string text = "This text needs truncating";
StringBuilder builder = new StringBuilder(text)
{
	Length = 10,
	[9] = '\u2026'
};
Console.WriteLine(builder);