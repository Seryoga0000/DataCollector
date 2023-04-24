using DataCollector.Model;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector.Services
{
    public class PlotModelBuilder
    {
        public PlotModel Build(IEnumerable<DataModel> data)
        {
            var plotModel = new PlotModel();
            var series = new LineSeries();
            foreach (var item in data)
            {
                foreach (var value in item.Data) {
                    series.Points.Add(new DataPoint(value.GetX(), value.GetY()));
                }
                //series.Points.Add(new DataPoint(item.Val.val, item.Dt.ToOADate()));
            }
            plotModel.Series.Add(series);
            return plotModel;
        }
    }
}
