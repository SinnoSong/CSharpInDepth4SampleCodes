<Query Kind="Statements" />

var names = new List<string> { "asd", "123" };
var actions = new List<Action>();
for (int i = 0; i < names.Count; i++)
{
	actions.Add(() => Console.WriteLine(names[i]));
}
foreach (var action in actions)
{
	action();
}