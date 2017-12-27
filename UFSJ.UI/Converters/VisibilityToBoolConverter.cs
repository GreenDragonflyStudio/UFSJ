using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace UFSJ.Converters
{
    public class VisibilityToBoolConverter : ValueConverter
    {
        public bool VisibleValue { get; set; }
        public bool CollapsedValue { get; set; }

        public override object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null)
                return CollapsedValue;
            return ((Visibility)value) == Visibility.Visible ? VisibleValue : CollapsedValue;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return value.Equals(this.VisibleValue) ? Visibility.Visible : Visibility.Collapsed;
        }
    }

}
