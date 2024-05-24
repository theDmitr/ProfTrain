using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using TaskManager.Common.Dtos;

namespace TaskManager.Client.Converters
{
    public class ProjectToNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parts = (value as string).ToUpper().Split(' ');
            return parts.Length == 1 ? parts[0][..2] : parts[0][0].ToString() + parts[0][1].ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
