<Query Kind="Program">
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

void Main()
{
	var dictionary = new ConcurrentDictionary<string, int>
	{
		{ "x", 10 },
		{ "y", 20 }
	};
}

public static class DictionaryExtensions
{
	public static void Add<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
	{
		dictionary.Add(key, value);
	}
}
