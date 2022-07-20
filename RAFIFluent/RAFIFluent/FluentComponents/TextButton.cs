using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class TextButton : Button
    {
        // Constants
        FluentColor _colors = new FluentColor();

        // Properties/Indexers
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(TextButton), false);

        public bool DarkMode
        {
            get { return (bool)GetValue(TextButton.darkMode); }
            set
            {
                SetValue(TextButton.darkMode, value);
                if (this.DarkMode == true)
                    this.BackgroundColor = _colors.Black;
                else
                    this.BackgroundColor = _colors.White;
            }
        }

        // Constructors
        public TextButton()
        {
            this.TextColor = _colors.ThemePrimary;
            this.BackgroundColor = _colors.White;
        }
    }
}
