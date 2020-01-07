using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class MembershipViewModel
    {
        [Key]
        public int UserDetailID { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }        
        public string ShipAddress { get; set; }         
        public DateTime BirthDay { get; set; }
        public string IdentityCard { get; set; }
        public string MemberRole { get; set; }
    }
}