<Query Kind="Statements" />

var words = new[] { "keys", "coat", "laptop", "bottle" };
var newWords = from word in words
let length = word.Length
where length > 4
orderby length
select string.Format("{0}: {1}", length, word.ToUpper());

foreach (var word in newWords)
{
	Console.WriteLine(word);
}