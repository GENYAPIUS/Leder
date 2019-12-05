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
        public IEnumerable<Product> GetProductInCatagory(int CategoryId, string sortedItem)
        {
            var result = _db.Products.Where(x => x.CategoryId == CategoryId).AsQueryable();

            if (sortedItem == "2") //當下拉式選單有變更
            {
                var result2 = result.OrderBy(m => m.Name); //用名稱分類
                return result2;
            }
            else if(sortedItem == "3")
            {
               var result2 = result.OrderBy(m => m.Price); //用價格分類(從低到高)
                return result2;
            }

            else if (sortedItem == "4")
            {
                var result2 = result.OrderByDescending(m => m.Price); //用價格分類(從高到低)
                return result2;
            }

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