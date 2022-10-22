<Query Kind="Program">
  <Namespace>System.Runtime.CompilerServices</Namespace>
</Query>

void Main()
{
	var derived1 = new Derived1();
	var derived2 = new Derived2();
	var derived3 = new Derived3();
}

public abstract class BaseClass
{
	protected BaseClass([CallerFilePath] string file = "Unspecified file",
	[CallerLineNumber] int line = -1,
	[CallerMemberName] string member = "Unspecified member")
	{
		Console.WriteLine("{0}:{1} - {2}", file, line, member);
	}

}

public class Derived1 : BaseClass
{
}
public class Derived2 : BaseClass
{
	// 隐式调用base()构造器
	public Derived2()
	{
	}
}
public class Derived3 : BaseClass
{
	public Derived3() : base()
	{
	}
}
