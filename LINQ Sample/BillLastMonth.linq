<Query Kind="Statements">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

// Get the following from the Bills table for the past month:
// BillDate, ID, people served, total potentially billable
// (BillItem.Quantity * BillItem.UnitCost),
// and actual bill amount
// Then display the total income for the month
// and the number of patrons served.

// The first principle when exploring the database/working on a problem
// get all the data (hold back on the filtering/where)
var billsLastMonth = from item in Bills
					 where item.PaidStatus == true //assumption
					 	&& item.BillDate.Month == DateTime.Today.Month - 1
						&& item.BillDate.Year == DateTime.Today.Year
					 orderby item.BillDate descending 
					 select new //item;
					 {
					 	BillDate = item.BillDate,
						ID = item.BillID,
						PeopleServed = item.NumberInParty,
						BillItems = item.BillItems, // <- temp
						TotalCost = item.BillItems.Sum(bi => bi.Quantity * bi.UnitCost),
						ActualTotal = item.BillItems.Sum(bi => bi.Quantity * bi.SalePrice)
					 };
					 
//billsLastMonth.Dump("Temporary output");

var totalIncome = billsLastMonth.Sum(blm => blm.ActualTotal);
totalIncome.Dump("Total Income");
// Play time...
var totalCost = billsLastMonth.Sum(blm => blm.TotalCost);
(totalIncome - totalCost).Dump("Profit");