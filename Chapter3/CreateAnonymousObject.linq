<Query Kind="Statements" />

#load ".\SampleClass"

var order = new Order();
var customer = new Customer();
var item = new OrderItem();

// edition 1
var flattenedItem = new
{
	order.OrderId,
	CustomerName = customer.Name,
	customer.Address,
	item.ItemId,
	item.Quantity
};
// edition 2
var flattenedItem1 = new
{
	OrderId = order.OrderId,
	CustomerName = customer.Name,
	Address = customer.Address,
	ItemId = item.ItemId,
	Quantity = item.Quantity
};