<Query Kind="Statements" />

static void Method(int x, int y = 5, int z = 10)
{
	Console.WriteLine($"x={x},y={y},z={z}");
}
Method(1, 2, 3); //x = 1; y = 2; z = 3
Method(x: 1, y: 2, z: 3); // x = 1; y = 2; z = 3
Method(z: 3, y: 2, x: 1); //x = 1; y = 2; z = 3
Method(1, 2); //x = 1; y = 2; z = 10
Method(1, y: 2); //x = 1; y = 2; z = 10
Method(1, z: 3); //x = 1; y = 5; z = 3
Method(1); //x = 1; y = 5; z = 10
Method(x: 1); //x = 1; y = 5; z = 10