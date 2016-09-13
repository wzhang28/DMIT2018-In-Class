<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Sample Order-by
from food in Items
// orderby food.Description descending
orderby food.CurrentPrice descending, food.Calories ascending
select food