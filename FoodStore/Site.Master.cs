using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using FoodStore.Models;
using System.Web.Optimization;

namespace FoodStore
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Product> GetProducts()
        {
            var _db = new FoodStore.Models.ProductContext();
            IQueryable<Product> querys = _db.Products;
            return querys;
        }
    }
}