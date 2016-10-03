<Query Kind="Program">
  <Connection>
    <ID>79c70a7c-2b3b-4d6d-9e69-2cae6efd6fa1</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>Chinook</Database>
  </Connection>
</Query>

void Main()
{
	//from person in Customers
	//select person
	//from purchase in Invoices
	//where purchase.BillingAddress != purchase.Customer.Address
	//select purchase
	
	// Assuming that we know the customer id, that would b epart of our query
	int customerid = 1;
	var profile = from person in Customers
				where person.CustomerId == customerid
				select new CustomerProfile()
	{
		FirstName = person.FirstName,
		LastName = person.LastName,
		CompanyName = person.Company,
		StreetAddress = person.Address,
		City = person.City,
		State = person.State,
		Country = person.Country,
		PostalCode = person.PostalCode
	};
	profile.Dump();
	
}

// Define other methods and classes here
public class CustomerProfile
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string CompanyName { get; set; }
	public string StreetAddress { get; set; }
	public string City { get; set; }
	public string State { get; set; }
	public string Country { get; set; }
	public string PostalCode { get; set; }
}