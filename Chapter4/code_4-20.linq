<Query Kind="Statements" />

IEnumerable<string> strings = new[] {"a", "b", "cdefg", "hij" };
List<object> list = strings.Where(x=>x.Length>1).Cast<object>().ToList();