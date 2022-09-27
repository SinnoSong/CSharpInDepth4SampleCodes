<Query Kind="Program" />

void Main()
{
	// other code
	var demo = new CapturedVariablesDemo();
	Action<string> action = demo.CreateAction("method argument");
	action("lambda argument");
}

public class CapturedVariablesDemo
{
	private string instanceField = "instance field";

	public Action<string> CreateAction(string methodParameter)
	{
		var methodLocal = "method local";
		var uncaptured = "uncaptured local";

		Action<string> action = lambdaParameter =>
		{
			string lambdaLocal = "lambda local";
			Console.WriteLine("Instance field: {0}", instanceField);
			Console.WriteLine("Method parameter: {0}", methodParameter);
			Console.WriteLine("Method local: {0}", methodLocal);
			Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
			Console.WriteLine("Lambda local: {0}", lambdaLocal);
		};
		methodLocal = "modified method local";
		return action;
	}
}