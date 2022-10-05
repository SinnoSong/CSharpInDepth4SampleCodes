<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
</Query>

async Task<string> FetchFirstSuccessfulAsync(IEnumerable<string> urls)
{
	var client = new HttpClient();
	foreach (var url in urls)
	{
		try
		{
			return await client.GetStringAsync(url);
		}
		catch (HttpRequestException ex)
		{
			Console.WriteLine($"Failed to fetch {url}: {ex.Message}");
		}
	}
	throw new HttpRequestException("No URLs successed");
}