<Query Kind="Program" />

static class MyClass
{
	static void Deconstruct(
	this DateTime dateTime, out int year, out int month, out int day) =>
	(year, month, day) = (dateTime.Year, dateTime.Month, dateTime.Day);

	static void Deconstruct(
	this DateTime dateTime, out int year, out int month, out int day
	out int hour, out int minute, out int second) =>
	(year, month, day, hour, minute, second) =
	(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);

	static void Main()
	{
		DateTime birthday = new DateTime(1999, 2, 19);
		DateTime now = DateTime.UtcNow;
		var (year, month, day, hour, minute, second) = now;
		(year, month, day) = birthday;
		Console.WriteLine($"{year:0000}-{month:00}-{day:00}");
	}
}

