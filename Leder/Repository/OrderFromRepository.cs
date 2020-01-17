using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class OrderFromRepository
    {
        private LederContext _db;

        public OrderFromRepository(LederContext context)
        {
            _db = context;
        }

        public IEnumerable<Order> GetAll()
        {
            var Result = _db.Orders.AsQueryable();
            return Result;
        }
    }
}