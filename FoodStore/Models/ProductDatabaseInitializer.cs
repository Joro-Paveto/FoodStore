using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FoodStore.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Chai",
                    UnitPrice = 18,
                    UnitsInStock = 39,
                    DeliveryOn = new DateTime(1996, 8, 20),
                    ImagePath = "Chai.jpg"
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Chang",
                    UnitPrice = 19,
                    UnitsInStock = 17,
                    DeliveryOn = new DateTime(1996, 7, 12),
                    ImagePath = "Chang.jpg"

                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Aniseed Syrup",
                    UnitPrice = 10,
                    UnitsInStock = 0,
                    DeliveryOn = new DateTime(1996, 8, 26),
                    ImagePath = "Aniseed.jpg"
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Chef Anton's Cajun Seasoning",
                    UnitPrice = 22,
                    UnitsInStock = 53,
                    DeliveryOn = new DateTime(1996, 9, 19),
                    ImagePath = "Anton.jpg"
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Chef Anton's Gumbo Mix",
                    UnitPrice = 21.35M,
                    UnitsInStock = 0,
                    DeliveryOn = new DateTime(1996, 7, 17),
                    ImagePath = "Gumbo.jpg"
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Grandma's Boysenberry Spread",
                    UnitPrice = 25,
                    UnitsInStock = 120,
                    DeliveryOn = new DateTime(1996, 9, 19),
                    ImagePath = "Grandma.jpg"
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Uncle Bob's Organic Dried Pears",
                    UnitPrice = 30,
                    UnitsInStock = 0,
                    DeliveryOn = new DateTime(1996, 7, 22),
                    ImagePath = "UncleBob.jpg"
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Northwoods Cranberry Sauce",
                    UnitPrice = 40,
                    UnitsInStock = 0,
                    DeliveryOn = new DateTime(1996, 11, 1),
                    ImagePath = "Northwood.jpg"
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Mishi Kobe Niku",
                    UnitPrice = 97,
                    UnitsInStock = 29,
                    DeliveryOn = new DateTime(1997, 1, 21),
                    ImagePath = "Kobe.jpg"
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Ikura",
                    UnitPrice = 31,
                    UnitsInStock = 31,
                    DeliveryOn = new DateTime(1996, 8, 5),
                    ImagePath = "Ikura.jpg"
                }
            };
            return products;
        }
    }
}