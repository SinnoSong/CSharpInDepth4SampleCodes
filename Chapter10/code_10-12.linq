<Query Kind="Statements" />

public interface ILogger
{
	IActiveLogger Debug { get; }
	IActiveLogger Info { get; }
	IActiveLogger Warning { get; }
	IActiveLogger Error { get; }
}
public interface IActiveLogger
{
	void Log(string message);
}