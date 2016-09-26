<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// The restaurant Host (who is in charge of the waiters),
// seats people and takes payment) needs the following information:
// Waiters with active customers (bills not paid)

// Here's an answer where we start with the Bills
//from customerBill in Bills
//where customerBill.PaidStatus == false
//select customerBill.Waiter

from employee in Waiters
from customerBill in empolyee.Bills
where customerBill.PaidStatus == false
select employee