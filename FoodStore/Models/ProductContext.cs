using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodStore.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("FoodStore")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}