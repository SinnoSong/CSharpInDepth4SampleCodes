<Query Kind="Statements" />

static bool LogAndReturn(string message, bool result)
{
	Console.WriteLine(message);
	return result;
}
static void Top()
{
	try
	{
		throw new Exception();
	}
	finally
	{
		Console.WriteLine("Top finally");
	}
}
static void Middle()
{
	try
	{
		Top();
	}
	catch (Exception e) when (LogAndReturn("Middle filter", false)) //永远不会进行捕获的异常过滤器
	{
		Console.WriteLine("Caught in middle");
	}
	finally
	{
		Console.WriteLine("Middle finally");
	}
}
static void Bottom()
{
	try
	{
		Middle();
	}
	catch (IOException e)
		when (LogAndReturn("Never called", true)) // 永远不会被调用的过滤器，因为异常的类型不对

	{
	}

	catch (Exception e)
		when (LogAndReturn("Bottom filter", true)) //每次都会进行捕获的过滤器

	{
		Console.WriteLine("Caught in Bottom");

	}
}
Bottom();