<Query Kind="Program" />

void Main()
{
	var dictionary = new Dictionary<string, Person>{
		{new Person{Name = "Jon"}}
	};
}
static class PersonDictionaryExtensions
{
	public static void Add(this Dictionary<string, Person> dictionary, Person person)
	{
		dictionary.Add(person.Name, person);
	}
}
public class Person
{
	public string Name { get; set; }
}
