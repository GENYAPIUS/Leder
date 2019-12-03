using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class CategoryRepository
    {
        private LederContext _db;

        public CategoryRepository(LederContext productContext)
        {
            _db = productContext;
        }

        
        public string GetCategoryNameById(int? CategoryId) //這一串可以移到ProductRepository嗎?
        {
            var temp = _db.Categories.FirstOrDefault(x => x.CategoryId == CategoryId);
            string result = temp.CategoryName;
            return result;
        }

    }
}