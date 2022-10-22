<Query Kind="Statements">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

[AttributeUsage(AttributeTargets.All)]
public class MemberDescriptionAttribute : Attribute
{
	public string File { get; }
	public int Line { get; }
	public string Member { get; }

	public MemberDescriptionAttribute(
		[CallerFilePath] string file = "Unspecified file",
		[CallerLineNumber] int line = 0,
		[CallerMemberName] string member = "Unspecified member")
	{
		File = file;
		Line = line;
		Member = member;
	}

	public override string ToString() =>
	   $"{Path.GetFileName(File)}:{Line} - {Member}";
}