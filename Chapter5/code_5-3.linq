<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{
	Console.WriteLine(DelayWithResultOfUnsafeCode("test"));
}

static async Task DelayWithResultOfUnsafeCode(string text)
{
	int total = 0;
	unsafe
	{
		fixed (char* textPointer = text)
		{
			char* p = textPointer;
			while (*p != 0)
			{
				total += *p;
				p++;
			}
		}
	}
	Console.WriteLine($"Delaying for {total}ms");
	await Task.Delay(total);
	Console.WriteLine("Delay complete");
}
