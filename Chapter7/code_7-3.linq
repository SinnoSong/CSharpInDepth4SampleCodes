<Query Kind="Statements">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

static void ShowInfo(
	[CallerFilePath] string file = null,
	[CallerLineNumber] int line = 0,
	[CallerMemberName] string member = null)
{
	Console.WriteLine($"{file}:{line} - {member}");
}
ShowInfo();