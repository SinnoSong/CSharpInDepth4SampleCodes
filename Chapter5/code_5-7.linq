<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static Task<int> ComputeLengthAsync(string text)
{
	if (text == null)
	{
		throw new ArgumentNullException(nameof(text));
	}
	return ComputeLengthAsyncImpl(text);
}
static async Task<int> ComputeLengthAsyncImpl(string text)
{
	await Task.Delay(500);
	return text.Length;
}