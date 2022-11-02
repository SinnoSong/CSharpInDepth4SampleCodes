<Query Kind="Statements" />

static (int min, int max) MinMax(IEnumerable<int> source)
{
	using (var iterator = source.GetEnumerator())
	{
		if (!iterator.MoveNext())
		{
			throw new InvalidOperationException("Cannot find min/max of an empty sequence");
		}
		var result = (min: iterator.Current, max: iterator.Current);
		while (iterator.MoveNext())
		{
			result = (Math.Min(result.min, iterator.Current), Math.Max(result.max, iterator.Current));
		}
		return result;
	}
}