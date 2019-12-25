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
        
        
        public string GetCategoryNameById(int? CategoryId)
        {
            var temp = _db.Categories.FirstOrDefault(x => x.CategoryId == CategoryId);
            string result = temp.CategoryName;
            return result;
        }

        //傳入路由的類別名稱(ex:Totebag)取得CategoryId
        public int GetCategoryId(string Category)
        {
            var temp = _db.Categories.FirstOrDefault(x => x.CategoryName == Category);
            if(temp == null)
            {
                return 0;  
            }
            else
            {
                int result = temp.CategoryId;
                return result;
            }         
        }

    }
}