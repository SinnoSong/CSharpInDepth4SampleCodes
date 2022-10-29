<Query Kind="Statements" />

static IEnumerable<int> Fibonacci()
{
	var pair = (current: 0, next: 1);
	while (true)
	{
		yield return pair.current;
		pair = (pair.next, pair.current + pair.next);
	}
}