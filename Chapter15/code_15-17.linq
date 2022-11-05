<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

public interface IGeoService
{
	Task<ListCitiesResponse> ListCitiesAsync(ListCitiesRequest request);
}

public class ListCitiesRequest
{
	public string PageToken { get; }
	public ListCitiesRequest(string pageToken) =>
		PageToken = pageToken;
}

public class ListCitiesResponse
{
	public string NextPageToken { get; }
	public List<string> Cities { get; }

	public ListCitiesResponse(string nextPageToken, List<string> cities) =>
		(NextPageToken, Cities) = (nextPageToken, cities);
}