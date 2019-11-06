using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace SampleValueConverter
{
    public class NumberToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string color = "";
            int colorNumber = (int)value;
            switch (colorNumber)
            {
                case 1:
                    color = "#ed0707";  // red
                    break;
                case 2:
                    color = "#34db25"; // green
                    break;
                case 3:
                    color = "#fcd46d"; // orange
                    break;
                case 4:
                    color = "#2e15eb"; // blue
                    break;
                case 5:
                    color = "#0ff2e3"; //violate
                    break;
                default:
                    color = "#000000";
                    break;
            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
