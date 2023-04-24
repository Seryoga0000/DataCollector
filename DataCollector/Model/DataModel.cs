using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector.Model
{
    public class DataModel
    {
        public IEnumerable<IDataLine> Data { get; set; } = null;

       
    }

    public interface IDataLine
    {
        double GetX();
        double GetY();

        IEnumerable<string> GetRow();
    }

    public struct DataLine:IDataLine
    {
        double x;
        double y;

        public DataLine(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public IEnumerable<string> GetRow()
        {
            return new List<string>() {x.ToString(),y.ToString()};
        }

        public double GetX()
        {
            return  x;
        }

        public double GetY()
        {
           return y;
        }
    }
    //public class DeviceData
    //{
    //    public IEnumerable<object> Data { get; set; } = null;
    //}

}
