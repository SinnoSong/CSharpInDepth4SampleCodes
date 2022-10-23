<Query Kind="Statements">
  <Namespace>System.ComponentModel</Namespace>
</Query>

public class Demo
{
	static Demo() => Console.WriteLine("Static constructor called");
	~Demo() => Console.WriteLine("Finializer called");

	private string name;
	private readonly int[] values = new int[10];

	public Demo(string name) => this.name = name;

	private PropertyChangedEventHandler handler;
	public event PropertyChangedEventHandler propertyChanged
	{
		add => handler += value;
		remove => handler -= value;
	}

	public int this[int index]
	{
		get => values[index];
		set => values[index] = value;
	}

	public string Name
	{
		get => name;
		set => name = value;
	}
}