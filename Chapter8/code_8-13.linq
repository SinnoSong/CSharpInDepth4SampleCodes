<Query Kind="Statements" />

public sealed class Point
{
	public double X { get; }
	public double Y { get; }

	public Point(double x, double y)
	{
		X = x;
		Y = y;
	}

	public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);
	//public double DistanceFromOrigin
	//{
	//	get { return Math.Sqrt(X * X + Y * Y); }
	//}
}