<Query Kind="Statements" />

var words = new[] { "keys", "coat", "laptop", "bottle" };
words.Select(word => new { word, length = word.Length })
	.Where(tmp => tmp.length > 4)
	.OrderBy(tmp => tmp.length)
	.Select(tmp => string.Format("{0}: {1}", tmp.length, tmp.word.ToUpper()));