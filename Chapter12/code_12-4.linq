<Query Kind="Statements" />

public sealed class Point
{
	public double X { get; }
	public double Y { get; }

	public Point(double x, double y) => (X, Y) = (x, y);
}