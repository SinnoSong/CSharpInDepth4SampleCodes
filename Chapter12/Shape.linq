<Query Kind="Statements">
  <Namespace>System.Windows.Shapes</Namespace>
  <Namespace>System.Windows.Media</Namespace>
</Query>

class Circle : Shape
{
	protected override Geometry DefiningGeometry => throw new NotImplementedException();
	public double Radius { get; set; }
}
class Triangle : Shape
{
	protected override Geometry DefiningGeometry => throw new NotImplementedException();
	public double SideA { get; set; }
	public double SideB { get; set; }
	public double SideC { get; set; }
}
