<Query Kind="Program">
  <Namespace>System.Globalization</Namespace>
</Query>

void Main()
{
	DateTime start = DateTime.UtcNow;
	PrintDateTime(start);
	PrintDateTime(in start);
	PrintDateTime(start.AddMinutes(1));
	//PrintDateTime(in start.AddMinutes(1)); compile error
}

static void PrintDateTime(in DateTime value)
{
	string text = value.ToString("yyyy-MM-dd'T'HH:mm:ss", CultureInfo.InvariantCulture);
	Console.WriteLine(text);
}