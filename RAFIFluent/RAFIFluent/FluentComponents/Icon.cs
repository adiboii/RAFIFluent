using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace RAFIFluent.FluentComponents
{
    public class Icon : SvgCachedImage
    {
        // Constructor
        public Icon()
        {
            this.Source = IconSource;
        }

        // Bindable Properties
        public static readonly BindableProperty iconSource = BindableProperty.Create(
          "IconSource", typeof(string), typeof(Icon), "");

        // Getters and Setters
        public string IconSource
        {
            get { return (string)GetValue(Icon.iconSource); }
            set { SetValue(Icon.iconSource, value); }
        }
    }
}
