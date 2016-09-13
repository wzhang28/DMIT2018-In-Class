<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Sample Group-By with an Anonymous Type
from food in Items
group food by food.MenuCategory.Description into result
// select result
select new {result.Description, result.CurrentPrice}