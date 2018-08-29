using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OxyPlotApp
{
    class SecondViewModel
    {
        public SecondViewModel()
        {
            PlotData = new PlotModel();

            PlotData.Axes.Add(new LinearAxis { Key="ox", Position = AxisPosition.Bottom });
            PlotData.Axes.Add(new LinearAxis { Key="oy", Position = AxisPosition.Left});
        }

        public PlotModel PlotData { get; private set; }
    }
}
