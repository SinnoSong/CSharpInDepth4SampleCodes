<Query Kind="Program" />

void Main()
{
	ArrayHolder holder = new ArrayHolder();
	ref int x = ref holder[0];
	ref int y = ref holder[0];

	x = 20;
	Console.WriteLine(y);
}
class ArrayHolder
{
	private readonly int[] array = new int[10];
	public ref int this[int index] => ref array[index];
}
