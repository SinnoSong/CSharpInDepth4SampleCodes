<Query Kind="Program" />

#load "Shape"
void Main()
{
	Rectangle r = new Rectangle() { Height = 5, Width = 4 };
	Triangle t = new Triangle() { SideA = 3, SideB = 4, SideC = 5 };
	Circle c = new Circle() { Radius = 5.5 };
	Console.WriteLine($"Perimeter of rectangle: {Perimeter(r)}");
	Console.WriteLine($"Perimeter of triangle: {Perimeter(t)}");
	Console.WriteLine($"Perimeter of circle: {Perimeter(c)}");
	Console.WriteLine(Perimeter(null));
}
static readonly Random random = new Random();

static double Perimeter(Shape shape)
{
	switch (shape ?? CreateRandomShape())
	{
		case Rectangle rect:
			return 2 * (rect.Height + rect.Width);
		case Circle circle:
			return 2 * Math.PI * circle.Radius;
		case Triangle triangle:
			return triangle.SideA + triangle.SideB + triangle.SideC;
		case var actualShape:
			throw new InvalidOperationException($"Shape type {actualShape.GetType()} perimeter unknown");
	}
}
static Shape CreateRandomShape()
{
	switch (random.Next(3))
	{
		case 0: return new Rectangle() { Width = random.Next(10), Height = random.Next(20) };
		case 1: return new Triangle() { SideA = random.Next(10), SideB = random.Next(10), SideC = random.Next(10) };
		case 2: return new Circle() { Radius = random.NextDouble() * 15 };
		default: throw new InvalidOperationException("Random violated its contract...");
	}
}
