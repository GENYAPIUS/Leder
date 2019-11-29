using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leder.ViewModels
{
    public class SliderPartialViewModel
    {
        public int Id { get; set; }
        public string ADTopic { get; set; }
        public string ADUrl { get; set; }
        public string ADStatement { get; set; }
        public string ADDiscount { get; set; }
        public string ADPageLink { get; set; }
    }
}