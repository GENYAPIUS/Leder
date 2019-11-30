using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Leder.Models;

namespace Leder.Repository
{
    public class ProductRepository //擴充方法static+this
    {
        private ProductContext _db;
        public ProductRepository(ProductContext productContext)
        {
            _db = productContext;
        }

        public IEnumerable<Product> GetAll()
        {
            var result = _db.Products.AsQueryable();
            return result;
        }

        public IEnumerable<Product> GetProductInCatagory(string Category)
        {
            var result = _db.Products.Where(x => x.Category == Category).AsQueryable();
            return result;
        }
    }
}