using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KIWI.Attached_Dependency_Properties
{
    public static class ButtonHelper
    {
        public static readonly DependencyProperty
            SecondaryColorProperty =
                DependencyProperty.RegisterAttached(
                    "SecondaryColor", typeof(string), typeof(ButtonHelper),
                    new PropertyMetadata("")); 
        public static string GetSecondaryColor(
            DependencyObject d)
        {
            return (string)d.GetValue(SecondaryColorProperty);
        }
        public static void SetSecondaryColor(
            DependencyObject d, string value)
        {
            d.SetValue(SecondaryColorProperty, value);
        }
    }
}
