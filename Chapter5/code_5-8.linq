<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static async Task ThrowCancellationException()
{
	throw new OperationCanceledException();
}
Task task = ThrowCancellationException();
Console.WriteLine(task.Status); //Canceled