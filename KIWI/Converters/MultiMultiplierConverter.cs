using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace KIWI.Converters
{
    /// <summary>
    /// Defines a converter which multiplies all provided values.
    /// The given parameter indicates number of arguments to multiply.
    /// </summary>
    public class MultiMultiplierConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double result = 1;
            int count = int.Parse((string)parameter);
            for (int i = 0; i < count; i++)
            {
                result *= (double)values[i];
            }
            return result;
        }
        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }
}
