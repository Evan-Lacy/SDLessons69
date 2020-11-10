using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _11_RestaurantRater.Models
{
    public class RestaurantDbContext : DbContext
    {
        //constructor inheritance
        //                           inherit from base constructor
        //                                  passing in default
        public RestaurantDbContext() : base("DefaultConnection") { }

        //property of RestaurantDbContext 
        //Making table of Restaurants - EntityFramework will convert our SQL db to Collection of C# Objects
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Rating> Ratings { get; set; }
    }
}