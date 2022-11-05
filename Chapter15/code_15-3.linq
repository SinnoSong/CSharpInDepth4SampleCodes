<Query Kind="Statements" />

#nullable enable
public class Customer
{
	public string Name { get; set; }
	public Address? Address { get; set; }
	public Customer(string name) => Name = name;
}
public class Address
{
	public string Country { get; set; }
	public Address(string country) => Country = country;
}