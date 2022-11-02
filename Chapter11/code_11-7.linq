<Query Kind="Statements" />

static IEnumerable<TResult> GenerateSequence<TState, TResult>(
	TState seed, Func<TState, TState> generator, Func<TState, TResult> resultSelector)
{
	var state = seed;
	while (true)
	{
		yield return resultSelector(state);
		state = generator(state);
	}
}

var fibonacci = GenerateSequence(
	(current: 0, next: 1),
	pair => (pair.next, pair.current + pair.next),
	pair => pair.current
);
Console.WriteLine(fibonacci);