<Query Kind="Expression">
  <Connection>
    <ID>ee562fbe-4f29-4570-abd8-1f698c5bb318</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from foodItem in BillItems
where foodItem.Bill.OrderPlaced.HasValue
	&& foodItem.Bill.OrderReady.HasValue == false
	&& foodItem.Item.MenuCategory.Description != "Beverage"
	// && foodItem.Bill.Reservation == null
group foodItem by new {foodItem.Bill.TableID, 
					   foodItem.Item.MenuCategory.Description}
into orderedItems
select new
{
	Table = orderedItems.Key.TableID,
	Type = orderedItems.Key.Description,
	Preps = from food in orderedItems
			select new
			{
				Description = food.Item.Description,
				Quantity = food.Quantity,
				Notes = food.Notes
			}
}