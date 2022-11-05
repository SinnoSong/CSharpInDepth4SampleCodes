<Query Kind="Program" />

struct OuterScope
{
	public int hour;
}
struct InnerScope
{
	public int minute;
}
void Main()
{
	DateTime now = DateTime.UtcNow;
	OuterScope outer = new OuterScope();
	outer.hour = now.Hour;
	if (outer.hour > 5)
	{
		InnerScope inner = new InnerScope();
		inner.minute = now.Minute;
		PrintValues(ref outer, ref inner);
	}
}
static void PrintValues(ref OuterScope outer, ref InnerScope inner)
{
	Console.WriteLine($"hour = {outer.hour}; minute = {inner.minute}");
}
