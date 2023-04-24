using DataCollector.Model;
using DataCollector.Services;
using DataCollector.View;
using DataCollector.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Unity;
using Unity.Injection;

namespace DataCollector
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new UnityContainer();
            container.RegisterType<DataModel>();
            container.RegisterType<IDataService, DataService>();
            container.RegisterType<MainWindowViewModel>();

            container.RegisterType<IDataService,DataService>();

            var mainView = new MainWindow();
            mainView.DataContext = container.Resolve<MainWindowViewModel>();
            mainView.Show();
        }
    }
}
