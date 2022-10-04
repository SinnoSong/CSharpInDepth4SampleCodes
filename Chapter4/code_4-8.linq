<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

class SimpleDynamicExample : DynamicObject
{
	public override bool TryInvokeMember(
		InvokeMemberBinder binder,
		object[] args,
		out object result)
	{
		Console.WriteLine($"Invoked: {binder.Name} ({string.Join(",", args)})");
		result = null;
		return true;
	}

	public override bool TryGetMember(
		GetMemberBinder binder,
		out object result)
	{
		result = "Fetched : " + binder.Name;
		return true;
	}
}
