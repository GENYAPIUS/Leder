
using System.Collections.Generic;

namespace Leder.ViewModels
{
    public class ChartViewModel
    {
        //�b�갵�XChartViewModel�ɱNLabel��Data�ݩʹ갵List<T>
        public ChartViewModel()
        {
            Label = new List<string>();
            Data = new List<int>();
        }
        public List<string> Label { get; set; }
        public List<int> Data { get; set; }
    }
}