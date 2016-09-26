<Query Kind="Statements">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Now we are writing C# as a set of program statements
// like it might appear inside a method

/* Example A: Query a simple array of strings*/
string[] names = {"Dan", "Don", "Sam", "Dwayne", "Laurel", "Steve", "Nathan"};
names.Dump(); // This will NOT work in Visual Studio!
var shortList = from person in names
				where person.StartsWith("D")
				select person;
shortList.Dump();

/* Example B: Querying data form eRestaurant */
var result = from row in Tables
			 where row.Capacity > 3 // Tables with more than three seats
			 select row;
result.Dump("List of tables that can seat more than three people");

/* Example C: Simple Data Types */
int age = 32;
age.Dump("Here is the value of the age variable");

(5 + 12 / 9.2).Dump();