<Query Kind="Statements">
  <Namespace>System.Windows.Shapes</Namespace>
  <Namespace>System.Windows.Media</Namespace>
</Query>

#load "Shape"
static double Perimeter(Shape shape)
{
	if (shape == null)
	{
		throw new ArgumentNullException(nameof(shape));
	}
	Rectangle rect = shape as Rectangle;
	if (rect != null)
	{
		return 2 * (rect.Height + rect.Width);
	}
	Circle circle = shape as Circle;
	if (circle != null)
	{
		return 2 * Math.PI * circle.Radius;
	}
	Triangle triangle = shape as Triangle;
	if (triangle != null)
		return triangle.SideA + triangle.SideB + triangle.SideC;
	throw new ArgumentException($"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
}