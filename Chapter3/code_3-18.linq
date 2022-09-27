<Query Kind="Statements" />

string[] words = { "keys", "coat", "laptop", "bottle" };
IEnumerable<string> query =
	Enumerable.Select(
		Enumerable.OrderBy(
			Enumerable.Where(words, word => word.Length > 4),
			word => word),
		word => word.ToUpper());