<Query Kind="Statements">
  <Namespace>System.Dynamic</Namespace>
</Query>

dynamic expando = new ExpandoObject();
expando.SomeData = "Some data";
Action<string> action = input => Console.WriteLine("The input was '{0}'", input);
expando.FakeMethod = action;

Console.WriteLine(expando.SomeData);
expando.FakeMethod("hello");

IDictionary<string, object> dictionary = expando;
Console.WriteLine("Keys: {0}", string.Join(",", dictionary.Keys));

dictionary["OtherData"] = "other";
Console.WriteLine(expando.OtherData);
