using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Client.ViewModels.Base;

namespace TaskManager.Client.ViewModels
{
    public class CalendarViewModel : ViewModelBase
    {
        public string[] Days { get; } = [ "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" ];
        public string[] Hours { get; } = [ "10:00", "12:00", "14:00", "16:00", "18:00", "20:00" ];

        public ChartValues<HeatPoint> Values { get; set; }

        public CalendarViewModel()
        {
            Values = new ChartValues<HeatPoint>();
            FillCharts();
        }

        private void FillCharts()
        {
            var rand = new Random();
            for (int i = 0; i < Hours.Length; i++)
                for (int j = 0; j < Days.Length; j++)
                    Values.Add(new HeatPoint(i, j, rand.Next(0, 10)));
        }
    }
}
