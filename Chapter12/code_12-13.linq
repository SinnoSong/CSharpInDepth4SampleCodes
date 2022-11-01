<Query Kind="Statements">
  <Namespace>System.Windows.Shapes</Namespace>
</Query>

#load "Shape"
static double Perimeter(Shape shape)
{
	if (shape == null)
	{
		throw new ArgumentNullException(nameof(shape));
	}
	if (shape is Rectangle rect)
	{
		return 2 * (rect.Height + rect.Width);
	}
	if (shape is Circle circle)
	{
		return 2 * Math.PI * circle.Radius;
	}
	if (shape is Triangle triangle)
		return triangle.SideA + triangle.SideB + triangle.SideC;
	throw new ArgumentException($"Shape type {shape.GetType()} perimeter unknown", nameof(shape));
}