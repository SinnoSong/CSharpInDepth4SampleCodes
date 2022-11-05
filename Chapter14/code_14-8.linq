<Query Kind="Program" />

#load ".\Preconditions"

public static IEnumerable<TResult> Select<TSource, TResult>(
	this IEnumerable<TSource> source, Func<TSource, TResult> selector)
{
	Preconditions.CheckNotNull(source, nameof(source)); 

	Preconditions.CheckNotNull(
		selector, nameof(selector));
	return SelectImpl(source, selector);
}

private static IEnumerable<TResult> SelectImpl<TSource, TResult>(
	IEnumerable<TSource> source,
	Func<TSource, TResult> selector)
{
	foreach (TSource item in source)

	{
		yield return selector(item);
	}
}
