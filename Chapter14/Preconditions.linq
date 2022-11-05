<Query Kind="Statements" />

class Preconditions
{
	internal static void CheckNotNull<TSource>(IEnumerable<TSource> source, string v)
	{
		throw new NotImplementedException();
	}

	internal static void CheckNotNull<TSource, TResult>(Func<TSource, TResult> selector, string v)
	{
		throw new NotImplementedException();
	}
}