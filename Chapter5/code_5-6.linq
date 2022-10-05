<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task Main()
{
	Task<int> task = ComputeLengthAsync(null);
	Console.WriteLine("Fetched the task");
	int length = await task;
	Console.WriteLine($"Length: {length}");
}

static async Task<int> ComputeLengthAsync(string text)
{
	if (text == null)
	{
		throw new ArgumentNullException(nameof(text));
	}
	await Task.Delay(500);
	return text.Length;
}
