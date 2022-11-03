<Query Kind="Statements" />

var array = new (int x, int y)[10];
for (int i = 0; i < array.Length; i++)
{
	array[i] = (i, i);
}
for (int i = 0; i < array.Length; i++)
{
	ref var element = ref array[i];
	element.x++;
	element.y *= 2;
}
foreach (var element in array)
{
	Console.WriteLine(element);
}