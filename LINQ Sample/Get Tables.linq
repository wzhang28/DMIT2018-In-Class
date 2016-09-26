<Query Kind="Statements">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get all the reataurant tables that have a srating capacity more than three
var result = from row in Tables
			 where row.Capacity > 3
			 select row;
result.Dump("Table that seat more than 3 people");
