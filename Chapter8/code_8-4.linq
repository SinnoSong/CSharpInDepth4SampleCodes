<Query Kind="Statements" />

public sealed class Point
{
	private readonly double x, y; //defind readonly field
	public double X { get { return x; } }
	public double Y { get { return y; } }

	public Point(double x, double y)
	{
		this.x = x;
		this.y = y;
	}
}