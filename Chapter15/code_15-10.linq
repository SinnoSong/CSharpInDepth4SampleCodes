<Query Kind="Statements" />

#load "..\Chapter12\Shape"

static double Perimeter(Shape shape) =>
	shape switch
	{
		null => throw new ArgumentNullException(nameof(shape)),
		Rectangle rect => 2 * (rect.Height + rect.Width),
		Circle circle => 2 * Math.PI * circle.Radius,
		Triangle triangle => triangle.SideA + triangle.SideB + triangle.SideC,
		_ => throw new ArgumentException(
			$"Shape type {shape.GetType()} perimeter unknown",
			nameof(shape))
	};
