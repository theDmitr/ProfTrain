using LiveCharts;
using LiveCharts.Defaults;
using Newtonsoft.Json.Linq;
using System.Windows;
using TaskManager.Client.ViewModels.Base;

namespace TaskManager.Client.ViewModels
{
    public class DashViewModel : ViewModelBase
    {
        public string[] Days { get; } = [ "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" ];
        public string[] Months { get; } = ["Sep", "Oct", "Nov", "Dec", "Jan", "Feb", 
                                                "Mar", "Apr", "May", "Jun", "Jul", "Aug" ];

        public ChartValues<HeatPoint> Values { get; set; }

        public DashViewModel()
        {
            Values = new ChartValues<HeatPoint>();
            FillCharts();
        }

        private void FillCharts()
        {
            var rand = new Random();
            for (int i = 0; i < Months.Length; i++)
                for (int j = 0; j < Days.Length; j++)
                    Values.Add(new HeatPoint(i, j, rand.Next(0, 10)));
        }
    }
}
