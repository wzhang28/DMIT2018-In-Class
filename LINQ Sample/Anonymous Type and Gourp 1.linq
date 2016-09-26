<Query Kind="Expression">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Generate a Object Graph of menu items by category where the inner-data
// is in a List<T>
from food in Items 
where food.MenuCategory.Description == "Entree"
	|| food.MenuCategory.Description == "Beverage"
orderby food.CurrentPrice descending
group food by food.MenuCategory into foodGroup
select new
{
	Category = foodGroup.Key.Description,
	MenuItems = foodGroup.ToList()
}