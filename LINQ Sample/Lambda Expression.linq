<Query Kind="Program">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

void Main()
{
	// Use a Lambda expression to get the bill that has the highest BillDate
	// A lambda is simple a shorthand version of a function call
	// that is ideal for anonymous delegates.
	Bills.Max( x => x.BillDate ).Dump();
	
	// Here is the "longer" version using an actual method name
	// that we pass in to the Max() method.
	// Note that the Max() method is overload, therefore we
	// need to specify in the generic identifier of the method
	// which version we are using.
	Bills.Max<Bills, DateTime>( GetProperty ).Dump();
}

// Define other methods and classes here
private DateTime GetProperty(Bills x)
{
	return x.BillDate;
}
