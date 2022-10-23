<Query Kind="Statements" />

public sealed class ReadOnlyListVIew<T> : IReadOnlyList<T>
{
	private readonly IList<T> list;
	public ReadOnlyListVIew(IList<T> list)
	{
		this.list = list;
	}

	public T this[int index] => list[index];

	public int Count => list.Count;

	public IEnumerator<T> GetEnumerator() => list.GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}