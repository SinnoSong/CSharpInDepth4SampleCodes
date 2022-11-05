<Query Kind="Program" />

#nullable enable

void Main()
{
	var customer = new Customer("hello");
	Address? address = customer.Address;
	if (address != null)
	{
		Console.WriteLine(address.Country);
	}
	else
	{
		Console.WriteLine("Address unknow");
	}
}

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