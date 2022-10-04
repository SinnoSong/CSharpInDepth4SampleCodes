<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Task task = DemoCompletedAsync();
	Console.WriteLine("Method returned");
	task.Wait();
	Console.WriteLine("Task completed");
}

static async Task DemoCompletedAsync()
{
	Console.WriteLine("Before first await");
	await Task.FromResult(10);
	Console.WriteLine("Between awaits");
	await Task.Delay(1000);
	Console.WriteLine("After second await");
}