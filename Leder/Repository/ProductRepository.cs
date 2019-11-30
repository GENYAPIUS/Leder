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

  

        //只抓特定類別的值，Namecard頁面只會秀出Namecard類別的商品
        public IEnumerable<Product> GetProductInCatagory(int CategoryId)
        {
            var result = _db.Products.Where(x => x.CategoryId == CategoryId).AsQueryable();
            return result;
        }

        //public IEnumerable<Product> GetProductInCatagory(string Category)
        //{
        //    var result = _db.Products.Where(x => x.CategoryId == Category).AsQueryable();
        //    return result;
        //}

        //public IEnumerable<Product> GetAll()
        //{
        //    var result = _db.Products.AsQueryable();
        //    return result;
        //}
    }
}