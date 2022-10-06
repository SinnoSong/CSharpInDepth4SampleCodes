<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

Func<int, Task<int>> function = async x =>
 {
	 Console.WriteLine($"Starting...x={x}");
	 await Task.Delay(1000);
	 Console.WriteLine($"Finished...x={x}");
	 return x * 2;
 };
 Task<int> first = function(5);
Task<int> second = function(3);
Console.WriteLine($"First result: {first.Result}");
Console.WriteLine($"Second result: {second.Result}");