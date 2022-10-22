<Query Kind="Program">
  <Namespace>MDA = MemberDescriptionAttribute</Namespace>
</Query>

#load "code_7-9"


[MemberDescription]
class CallerNameInAttribute
{
	[MemberDescription]
	public void Method<[MemberDescription] T>([MemberDescription] int parameter) { }

	static void Main()
	{
		var typeInfo = typeof(CallerNameInAttribute).GetTypeInfo();
		var methodInfo = typeInfo.GetDeclaredMethod("Method");
		var paramInfo = methodInfo.GetParameters()[0];
		var typeParamInfo =
			methodInfo.GetGenericArguments()[0].GetTypeInfo();
		Console.WriteLine(typeInfo.GetCustomAttribute<MDA>());
		Console.WriteLine(methodInfo.GetCustomAttribute<MDA>());
		Console.WriteLine(paramInfo.GetCustomAttribute<MDA>());
		Console.WriteLine(typeParamInfo.GetCustomAttribute<MDA>());
	}
}
