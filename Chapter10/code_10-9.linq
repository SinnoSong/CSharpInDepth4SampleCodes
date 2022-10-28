<Query Kind="Statements" />

static class ListExtensions
{
	public static void Add<T>(this List<T> list, IEnumerable<T> collection)
	{
		list.AddRange(collection);
	}
}