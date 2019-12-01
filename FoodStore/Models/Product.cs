using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodStore.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public DateTime DeliveryOn { get; set; }
        public string ImagePath { get; set; }
    }
}