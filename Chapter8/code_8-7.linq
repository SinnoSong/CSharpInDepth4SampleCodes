<Query Kind="Statements" />

public class Person
{
	private List<Person> friends = new List<Person>();
	public List<Person> Friends
	{
		get { return friends; }
		set { friends = value; }
	}
}