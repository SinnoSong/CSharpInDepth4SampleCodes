<Query Kind="Statements" />

List<dynamic> source = new List<dynamic>()
{
	5,2.75,TimeSpan.FromSeconds(45)
};
IEnumerable<dynamic> query = source.Select(x => x * 2);
foreach (var value in query)
{
	Console.WriteLine(value);
}