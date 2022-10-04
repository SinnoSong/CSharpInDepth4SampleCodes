<Query Kind="Statements" />

dynamic source = new List<dynamic>()
{
	5,2.75,TimeSpan.FromSeconds(45)
};
Console.WriteLine(Enumerable.Any(source));
//Console.WriteLine(source.Any()); //RuntimeBinderException