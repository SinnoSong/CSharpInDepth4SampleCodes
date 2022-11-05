<Query Kind="Statements" />

public class Customer
{
	public string Name { get; set; }
	public Address Address { get; set; }
	public Customer(string name, Address address) => (Name, Address) = (name, address);
}
public class Address
{
	public string Country { get; set; }
	public Address(string country) => Country = country;
}