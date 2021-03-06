<Query Kind="Statements">
  <Connection>
    <ID>c4382204-6d69-474a-8b63-d17d56f323ab</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get the total bill amount for Bill ID # 104
var billData = (from theItems in BillItems
			   where theItems.BillID == 104
			   select theItems.SalePrice * theItems.Quantity).Sum();
billData.Dump();

// (see how many people were being served in that bill)
var peopleCount = from theBill in Bills
				  where theBill.BillID == 104
				  select theBill.NumberInParty;
peopleCount.Dump();

// same as the  first line, but done with Method syntax
billData = BillItems.Where (theItem => theItem.BillID == 104)
					.Select (theItem => theItem.SalePrice * theItem.Quantity)
					.Sum();
billData.Dump("The bill amount obtained through method syntax");

// Again, getting the same data, but starting from the Bills table
// First, as Query Syntax
var data = from customer in Bills
		   where customer.BillID == 104
		   select customer.BillItems.Sum( theItem => theItem.SalePrice * theItem.Quantity);
billData.Dump("The bill amount, starting with the Bill table, and using Query Syntax with some Method Syntax");

// Then, as pure method syntax
data = Bills.Where (customer => customer.BillID == 104)
				.Select (
					customer =>
						customer.BillItems.Sum(theItem => theItem.SalePrice * (Decimal)(theItem.Quantity))
						);
data.Dump("The bill amount, starting with the Bill table, and using only Method Syntax");