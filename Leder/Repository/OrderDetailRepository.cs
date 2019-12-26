using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class OrderDetailRepository
    {
        private LederContext _db;
        public OrderDetailRepository(LederContext context)
        {
            _db = context;
        }

        public decimal GetAmountByProductid(int id)
        {
           decimal amount = 0;
            var  temp = _db.OrderDetails.Where(x=>x.ProductId==id);
            foreach(var i in temp)
            {
                amount += i.Amount;
            }
            return amount;
        }
    }

   
}