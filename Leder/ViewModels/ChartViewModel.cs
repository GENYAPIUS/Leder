
using System.Collections.Generic;

namespace Leder.ViewModels
{
    public class ChartViewModel
    {
        //在實做出ChartViewModel時將Label及Data屬性實做List<T>
        public ChartViewModel()
        {
            Label = new List<string>();
            Data = new List<int>();
        }
        public List<string> Label { get; set; }
        public List<int> Data { get; set; }
    }
}