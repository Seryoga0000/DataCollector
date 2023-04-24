using DataCollector.Model;
using DataCollector.Services;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DataCollector.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly  IDataService _deviceDataService;
        private readonly PlotModelBuilder _plotModelBuilder;
        private readonly TableBuilder _tableBuilder;
        public MainWindowViewModel(IDataService service)
        {
            _deviceDataService = service;

            var timer = new Timer(10000);
            timer.Elapsed += OnTimerElapsed;
            timer.Start();

            _plotModelBuilder= new PlotModelBuilder();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {

        }
        public ObservableCollection<DataModel> Data { get; } = 

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public void LoadData()
        {
            //Message = _service.GetData();
        }

        private OxyPlot.PlotModel plotModel;

        public OxyPlot.PlotModel PlotModel=> _plotModelBuilder.Build(Data);
    }
}
