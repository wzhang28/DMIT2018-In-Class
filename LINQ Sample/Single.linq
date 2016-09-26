<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// List all the waiters whose first name satrts with "S"
//Waiters.Where(person => person.FirstName.StartsWith("S"))

//Waiters.Single(person => person.FirstName.StartsWith("S"))

Waiters.SingleOrDefault(person => person.FirstName.StartsWith("W"))