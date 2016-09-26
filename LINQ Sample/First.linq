<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Waiters.First()

//Waiters.First(person => person.FirstName.StartsWith("D"))
// |             |               string
// |        A Single Waiter
// Collection of "rows"

//(from person in Waiters
//where person.FirstName.StartsWith("D")
//select person).First()

Waiters.Where(person => person.FirstName.StartsWith("D"))