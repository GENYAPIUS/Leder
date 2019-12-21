using Leder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Repository
{
    public class ProcurementRepository
    {
        private LederContext _db;

        public ProcurementRepository(LederContext context)
        {
            _db = context;
        }

        public IEnumerable<Procurement> GetAll()
        {
            var Result = _db.Procurement.AsQueryable();
            return Result;
        }

        

    }

}