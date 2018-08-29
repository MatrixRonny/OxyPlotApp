using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotApp
{
    class MainViewModel
    {
        public MainViewModel()
        {
            FirstViewModel firstVm = new FirstViewModel();
            SecondViewModel secondVm = new SecondViewModel();

            NavigationItems = new ArrayList
            {
                firstVm,
                secondVm,
                new IntermediateViewModel(secondVm)
            };
        }

        public ArrayList NavigationItems { get; private set; }
    }
}
