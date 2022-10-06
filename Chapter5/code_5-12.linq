<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task Main()
{
	Console.WriteLine("Before delay");
	await Task.Delay(1000);
	Console.WriteLine("After delay");
}