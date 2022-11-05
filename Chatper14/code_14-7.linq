<Query Kind="Statements" />

class Program
{
	void Main()
	{
		var counter = CreateCounter();
		counter();
		counter();
	}
	static Action CreateCounter()
	{
		CountHolder holder = new CountHolder();
		holder.count = 0;
		return holder.Count;
	}
	private class CountHolder
	{
		public int count;
		public void Count() => Console.WriteLine(count++);
	}
}
