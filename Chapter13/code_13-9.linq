<Query Kind="Program" />

static (int even, int odd) CountEvenAndOdd(IEnumerable<int> values)
{

	var result = (even: 0, odd: 0);
	foreach (var value in values)
	{
		ref int counter = ref (value & 1) == 0 ? ref result.even : ref result.odd;
		counter++;
	}
	return result;
}