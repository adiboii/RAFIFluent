using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class TextButton : Button
    {
        // Local Declartions
        FluentColor colors = new FluentColor();

        // Constructors
        public TextButton()
        {
            this.TextColor = colors.ThemePrimary;
            this.BackgroundColor = colors.White;
        }

        // Bindable Properties
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(TextButton), false);

        // Getters and Setters
        public bool DarkMode
        {
            get { return (bool)GetValue(TextButton.darkMode); }
            set
            {
                SetValue(TextButton.darkMode, value);
                if (this.DarkMode == true)
                    this.BackgroundColor = colors.Black;
                else
                    this.BackgroundColor = colors.White;
            }
        }
    }
}
