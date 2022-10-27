<Query Kind="Statements">
  <Namespace>System.Windows</Namespace>
</Query>

using static System.Math;

static Point PolarToCartesian(double degrees, double magnitude)
{
	double radians = degrees * PI / 180;
	return new Point(Cos(radians) * magnitude, Sin(radians) * magnitude);
}
