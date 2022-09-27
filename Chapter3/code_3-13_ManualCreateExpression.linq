<Query Kind="Statements" />

var xParameter = Expression.Parameter(typeof(int), "x");
var yParameter = Expression.Parameter(typeof(int), "y");
var body = Expression.Add(xParameter, yParameter);
var parameters = new[] { xParameter, yParameter };

var adder = Expression.Lambda<Func<int, int, int>>(body, parameters);
Console.WriteLine(adder);