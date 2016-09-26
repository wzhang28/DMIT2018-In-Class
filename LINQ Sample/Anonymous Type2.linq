<Query Kind="Statements">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

string[] instructors = {"Dan", "Don", "Dwayne", "Steve", "Laurel", "Yvonne", "Nathan", "Allan", "Sam", "Mike"};

var numberOfInstructors = instructors.Count();
numberOfInstructors.Dump();

var menuData = from category in MenuCategories
			   select new // ANON type
				{
					Category = category.Description,
					ItemCount = category.Items.Count()
				};
				
menuData.Dump("Menu Categories");