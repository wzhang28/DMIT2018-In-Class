﻿using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Data.Entity
{
    // : DbContext means that my class ingerits from th ebContext class
    internal class RestaurantContext : DbContext
    {
        // : base(string) is the constructor of the DbContext class that I call 
        //                 before running the body of my own constructor.
        // Hooking up constructors to call other constructors is called
        // "Constructor Chaining"
        public RestaurantContext() : base("name=EatIn") { }

        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<Item> Items { get; set; }


    }
}
