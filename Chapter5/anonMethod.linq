<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Func<Task> lambda = async() => await Task.Delay(1000);
Func<Task<int>> anonMethod = async delegate()
{
	Console.WriteLine("Started");
	await Task.Delay(1000);
	Console.WriteLine("Finished");
	return 10;
}