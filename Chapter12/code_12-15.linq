<Query Kind="Statements" />

#load "Shape"
static void DisplayShapes<T>(List<T> shapes) where T : Shape
{
	foreach (T shape in shapes)
	{
		switch (shape)
		{
			case Circle c:
				Console.WriteLine($"Circle radius {c.Radius}");
				break;
			case Rectangle r:
				Console.WriteLine($"Rectangle {r.Width} x {r.Height}");
				break;
			case Triangle t:
				Console.WriteLine($"Triangle sides {t.SideA},{t.SideB},{t.SideC}");
				break;
		}
	}
}