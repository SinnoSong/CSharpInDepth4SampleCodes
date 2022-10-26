<Query Kind="Program" />

class OtherClass
{
	public static int StaticMember => 3;
	public int InstanceMember => 3;
}
class QualifiedNameof
{
	static void Main()
	{
		OtherClass instance = null;
		Console.WriteLine(nameof(instance.InstanceMember));
		Console.WriteLine(nameof(OtherClass.StaticMember));
		Console.WriteLine(nameof(OtherClass.InstanceMember));
	}
}