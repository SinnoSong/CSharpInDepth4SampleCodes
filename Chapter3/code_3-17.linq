<Query Kind="Statements" />

var words = new[] { "keys", "coat", "laptop", "bottle" };
var query = words.Where(word => word.Length > 4).OrderBy(word => word).Select(word => word.ToUpper());
foreach (var word in query)
{
	Console.WriteLine(word);
}