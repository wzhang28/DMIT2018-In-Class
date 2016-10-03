<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from customer in Bills
where customer.PaidStatus == false
select new
{
	BillID = customer.BillID,
	Name = customer.Waiter.FirstName + " " + customer.Waiter.LastName,
	Placed = customer.OrderPlaced,
	Ready = customer.OrderReady,
	Served = customer.OrderServed
}