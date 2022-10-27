<Query Kind="Statements" />

using static System.Linq.Enumerable;

IEnumerable<string> strings = new[] { "a", "b", "c" };

var valid = strings.Count();
//var invalid = Count(strings);