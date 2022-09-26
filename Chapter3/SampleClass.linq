<Query Kind="Program" />

public class Order
{
	private readonly List<OrderItem> items = new List<OrderItem>();

	public string OrderId { get; set; }
	public Customer Customer { get; set; }
	public List<OrderItem> Items { get { return items; } }
}

public class Customer
{
	public string Name { get; set; }
	public string Address { get; set; }
}

public class OrderItem
{
	public string ItemId { get; set; }
	public int Quantity { get; set; }
}