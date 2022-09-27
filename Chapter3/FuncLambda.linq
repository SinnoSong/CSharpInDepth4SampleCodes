<Query Kind="Statements" />

Func<int, int, int> multiply = (int x, int y) => { return x * y; };

Func<int, int, int> multiply1 = (int x, int y) => x * y;

Func<int, int, int> multiply2 = (x, y) => x * y;

Func<string, int> squareLength = (string text) =>
{
	int length = text.Length;
	return length * length;
}

Func<string, int> squareLength1 = (text) =>
{
	int length = text.Length;
	return length * length;
}

Func<string, int> squareLength2 = text =>
{
	int length = text.Length;
	return length * length;
};
Func<string, int> squareLength3 = text => text.Length * text.Length;
