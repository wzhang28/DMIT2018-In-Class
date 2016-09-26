<Query Kind="Expression">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Group alll the menu items by the menu category
from food in Items
group food by food.MenuCategoryID
// The following does the same thing, but places the grouped date into 
// another variable called "result"
/*
from food in Items
group food by food.MenuCategoryID into result
select result
*/