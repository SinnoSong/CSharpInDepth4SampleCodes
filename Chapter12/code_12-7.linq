<Query Kind="Program" />

void Main()
{
	var point = new Point(1.5, 20);
	var (x, y) = point;
	Console.WriteLine($"x = {x}");
	Console.WriteLine($"y = {y}");
}

class Point
{
	public double X { get; set; }
	public double Y { get; set; }

	public Point(double x, double y) => (X, Y) = (x, y);
	public void Deconstruct(out double x, out double y) => (x, y) = (X, Y);
}
