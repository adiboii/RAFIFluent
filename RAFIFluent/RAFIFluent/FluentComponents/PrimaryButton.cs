using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace component.xamarin.fluentui.FluentComponents
{
    public class PrimaryButton : Button
    {
        // Constants
        FluentColor _colors = new FluentColor();

        // Properties/Indexers
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(PrimaryButton), false);

        public bool DarkMode
        {
            get { return (bool)GetValue(PrimaryButton.darkMode); }
            set
            {
                SetValue(PrimaryButton.darkMode, value);
                if (this.DarkMode == true)
                    this.TextColor = _colors.Black;
                else
                    this.TextColor = _colors.White;
            }
        }

        // Constructor
        public PrimaryButton()
        {
            this.BackgroundColor = _colors.ThemePrimary;
        }
    }
}
