<Query Kind="Statements" />

var words = new[] { "keys", "coat", "laptop", "bottle" };

var query = from word in words
			where word.Length > 4
			orderby word
			select word.ToUpper();
foreach (var word in query)
{
	Console.WriteLine(word);
}