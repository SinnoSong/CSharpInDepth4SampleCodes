<Query Kind="Statements" />

static (int min, int max) MinMax(IEnumerable<int> source)
{
	using (var iterator = source.GetEnumerator())
	{
		if (!iterator.MoveNext())
		{
			throw new InvalidOperationException("Cannot find min/max of an empty sequence");
		}
		int min = iterator.Current;
		int max = iterator.Current;
		while (iterator.MoveNext())
		{
			min = Math.Min(min, iterator.Current);
			max = Math.Max(max, iterator.Current);
		}
		return (min, max);
	}
}