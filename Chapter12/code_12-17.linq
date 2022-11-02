<Query Kind="Statements" />

static int Fib(int n)
{
	switch (n)
	{
		case 0: return 0;
		case 1: return 1;
		case var _ when n > 1: return Fib(n - 2) + Fib(n - 1);
		default: throw new ArgumentOutOfRangeException(nameof(n), "Input must be non-negative");
	}
}