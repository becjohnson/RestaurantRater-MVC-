using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        [Key]
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }
    public class RestaurantDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}