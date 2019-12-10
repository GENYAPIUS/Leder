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
        private LederContext _db;
        public ProductRepository(LederContext productContext)
        {
            _db = productContext;
        }

        //只抓特定類別的值，Namecard頁面只會秀出Namecard類別的商品
        public IEnumerable<Product> GetProductInCatagory(int CategoryId)
        {
            var result = _db.Products.Where(x => x.CategoryId == CategoryId).AsQueryable();
            return result;
        }
       
        
        //給ProductDetail呼叫
        public IEnumerable<Product> GetAll()
        {
            var result = _db.Products.AsQueryable();
            return result;
        }
    }
}