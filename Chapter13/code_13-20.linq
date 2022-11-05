<Query Kind="Statements" />

static string Generate(string alphabet, Random random, int length)
{
	char[] chars = new char[length];
	for (int i = 0; i < length; i++)
	{
		chars[i] = alphabet[random.Next(alphabet.Length)];
	}
	return new string(chars);
}