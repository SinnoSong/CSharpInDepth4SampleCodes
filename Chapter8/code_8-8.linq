<Query Kind="Statements" />

public class Person
{
	public List<Person> Friends { get; set; }
	public Person()
	{
		Friends = new List<Person>();
	}
}