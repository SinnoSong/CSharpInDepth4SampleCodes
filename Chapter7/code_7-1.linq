<Query Kind="Statements" />

var names = new List<string> { "asd", "123" };
var actions = new List<Action>();
foreach (var name in names)
{
	actions.Add(() => Console.WriteLine(name));
}
foreach (var action in actions)
{
	action();
}