<Query Kind="Statements" />

static T Retry<T>(Func<T> operation, int attempts)
{
	while (true)
	{
		try
		{
			attempts--;
			return operation();
		}
		catch (Exception ex) when (attempts > 0)
		{
			Console.WriteLine($"Failed :{ex}");
			Console.WriteLine($"Attempts left:{attempts}");
			Thread.Sleep(5000);
		}
	}
}

Func<DateTime> temporamentalCall = () =>
 {
	 DateTime utcNow = DateTime.UtcNow;
	 if (utcNow.Second < 30)
	 {
		 throw new Exception("It's not the time!");
	 }
	 return utcNow;
 };
var result = Retry(temporamentalCall, 3);
Console.WriteLine(result);
