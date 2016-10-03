<Query Kind="Expression">
  <Connection>
    <ID>4828949c-9ae6-421a-bab9-5f4147e54d01</ID>
    <Server>.</Server>
    <Database>eRestaurant</Database>
  </Connection>
</Query>

from booking in Reservations
where booking.ReservationStatus != 'X'
	&& booking.ReservationDate.Year == 2016
	&& booking.ReservationDate.Month == 9
	&& booking.ReservationDate.Day == 20
// select booking
group booking by booking.ReservationDate.Hour
//  	into hourlyBooking
//select hourlyBooking