using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class ProcurementViewModel
    {
        [Key]
        public int ProcurementId { get; set; }
        public string Name { get; set; }
        public string PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public int UnitPrize { get; set; }

        public int ProductId { get; set; }


    }
}