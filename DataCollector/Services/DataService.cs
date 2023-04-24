using DataCollector.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollector.Services
{
    public interface IDataService
    {
        DataModel ReadData();
    }
  
    public class DataService : IDataService
    {
        Random rnd= new Random();

        public DataService()
        {
            
        }

        public DataModel ReadData()
        {

            DataModel dataModel = new DataModel();
            List<IDataLine> dataLines = new List<IDataLine>
            {
                new DataLine(rnd.NextDouble(), rnd.NextDouble()),
                new DataLine(rnd.NextDouble(), rnd.NextDouble()),
                new DataLine(rnd.NextDouble(), rnd.NextDouble())
            };
            dataModel.Data= dataLines;
            return dataModel;
        }
    }
}
