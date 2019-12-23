using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.Models
{
    public class ApprovedResult
    {
        //成功部分
        public string id { get; set; }
        public string create_time { get; set; }
        public string update_time { get; set; }
        public string state { get; set; }
        public string intent { get; set; }
    }
}