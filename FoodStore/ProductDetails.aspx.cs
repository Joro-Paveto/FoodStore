using FoodStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FoodStore
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.Parse(Request.QueryString["unitsinstock"]) == 0)
            {
                string stock = "Out of Stock";
            }
        }


        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId)
        {
            var _db = new FoodStore.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            if (productId.HasValue && productId > 0)
            {
                query = query.Where(p => p.ProductID == productId);
            }
            else
            {
                query = null;
            }
            return query;
        }
        public int GetStock([QueryString("productID")] int? productId)
        {
            var _db = new FoodStore.Models.ProductContext();
            IQueryable<Product> query = _db.Products;
            query = query.GroupBy(p => p.ProductID == productId)
                .Select(o => o.First());
            return int.Parse(query.ToString());

        }
    }
}