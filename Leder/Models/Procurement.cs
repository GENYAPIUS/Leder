using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class Procurement
    {
        [Key]
        public int ProcurementId { get; set; }
        public int ProductId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrize { get; set; }
     
        [ForeignKey("ProductId")]

        public virtual Product Product { get; set; }
    }
}