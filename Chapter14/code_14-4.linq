<Query Kind="Program" />

void Main()
{
	DateTime now = DateTime.UtcNow;
	int hour = now.Hour;
	if (hour > 5)
	{
		int minute = now.Minute;
		PrintValues();
		void PrintValues() =>
			Console.WriteLine($"Hour = {hour};Minute = {minute}");
	}
}

