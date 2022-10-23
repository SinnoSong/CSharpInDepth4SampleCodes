<Query Kind="Statements">
  <Namespace>System.Windows</Namespace>
</Query>

public sealed class Point
{
	public double X { get; }
	public double Y { get; }

	public Point(double x, double y)
	{
		X = x;
		Y = y;
	}

	public static Point Add(Point left, Vector right) => left + right;

	public static Point operator +(Point left, Vector right) =>
		new Point(left.X + right.X, left.Y + right.Y);

}