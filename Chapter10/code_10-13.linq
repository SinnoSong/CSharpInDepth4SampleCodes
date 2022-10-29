<Query Kind="Statements" />

string[] messages =
{
	"You can catch this",
	"You can catch this too",
	"This won't be caught"
};
foreach (var message in messages)
{
	try
	{
		throw new Exception(message);
	}
	catch (Exception ex) when (ex.Message.Contains("catch")) //只有message包含catch时才捕获
	{
		Console.WriteLine($"Caught '{ex.Message}'");
	}
}