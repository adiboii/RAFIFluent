using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class PrimaryButton : Button
    {
        // Local Declartions
        FluentColor colors = new FluentColor();

        // Constructors
        public PrimaryButton()
        {
            this.BackgroundColor = colors.ThemePrimary;
        }

        // Bindable Properties
        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(PrimaryButton), false);

        // Getters and Setters
        public bool DarkMode
        {
            get { return (bool)GetValue(PrimaryButton.darkMode); }
            set
            { 
              SetValue(PrimaryButton.darkMode, value);
              if (this.DarkMode == true)
                this.TextColor = colors.Black;
              else
                this.TextColor = colors.White;
            }
        }
    }
}
