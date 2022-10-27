<Query Kind="Statements">
  <Namespace>System.Windows</Namespace>
</Query>

static Point PolarToCartesian(double degrees, double magnitude)
{
	double radians = degrees * Math.PI / 180;
	return new Point(Math.Cos(radians) * magnitude, Math.Sin(radians) * magnitude);
}
