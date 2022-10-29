<Query Kind="Statements" />

static IEnumerable<int> Fibonacci()
{
	int current = 0;
	int next = 1;
	while (true)
	{
		yield return current;
		int nextNext = current + next;
		current = next;
		next = nextNext;
	}
}