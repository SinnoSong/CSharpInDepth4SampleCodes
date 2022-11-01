<Query Kind="Statements" />

#load "Shape"
static double Perimeter(Shape shape)
{
	switch (shape)
	{
		case null:
			throw new ArgumentNullException(nameof(shape));
		case Rectangle rect:
			return 2 * (rect.Height + rect.Width);
		case Circle circle:
			return 2 * PI * circle.Radius;
		case Triangle tri:
			return tri.SideA + tri.SideB + tri.SideC;
		default:
			throw new ArgumentException();
	}
}