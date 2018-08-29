using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotApp
{
    class IntermediateViewModel
    {
        public IntermediateViewModel(Object data)
        {
            Data = data;
        }

        public Object Data { get; private set; }
    }
}
