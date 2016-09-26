<Query Kind="Expression">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Picking and choosing what data to extract by using Anonymous Types
from food in Items 
where food.MenuCategory.Description == "Entree" && food.Active
orderby food.CurrentPrice descending
select new // This is saying I want a new Anonymous type
{  // These are the properties/values in the Anonymous type
	Description = food.Description,
	Price = food.CurrentPrice,
	Calories = food.Calories
}