<Query Kind="Expression">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get the menu items for Entree and sort them by price highest to lowest
from food in Items
where food.MenuCategory.Description == "Entree"
orderby food.CurrentPrice descending
select food

// Get the menu items for Entree & Beverages (grouped separately) 
// and sort them by price highest to lowest
from food in Items
where food.MenuCategory.Description == "Entree" 
	|| food.MenuCategory.Description == "Beverage"
orderby food.CurrentPrice descending
group food by food.MenuCategory.Description into result
select result