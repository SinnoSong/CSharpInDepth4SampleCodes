<Query Kind="Program" />

void Main()
{
	try
	{
		UnreliableMethod();
	}
	catch (Exception ex) when (Log(ex))
	{

	}
}

static void UnreliableMethod()
{
	throw new Exception("Bang!");
}

static bool Log(Exception e)
{
	Console.WriteLine($"{DateTime.UtcNow}: {e.GetType()} {e.Message}");
	return false;
}