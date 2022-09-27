<Query Kind="Statements" />

static List<Action> CreateActions()
{
	List<Action> actions = new List<Action>();
	for (int i = 0; i < 5; i++)
	{
		string text = string.Format("message {0}", i);
		actions.Add(() => Console.WriteLine(text));
	}
	return actions;
}
List<Action> actions = CreateActions();
foreach (var action in actions)
{
	action();
}