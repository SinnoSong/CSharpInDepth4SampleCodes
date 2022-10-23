<Query Kind="Statements" />

public struct Point
{
	public double X { get; }
	public double Y { get; }

	public Point(double x, double y) : this()
	{
		X = x;
		Y = y;
	}
}