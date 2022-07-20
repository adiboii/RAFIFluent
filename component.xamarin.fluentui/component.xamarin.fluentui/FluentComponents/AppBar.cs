using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;

namespace component.xamarin.fluentui.FluentComponents
{
    internal class AppBar : Frame
    {
        // Local Declarations
        FluentColor _colors = new FluentColor();
        StackLayout _appBar = new StackLayout();
        StackLayout _titles = new StackLayout();
        Label _title;
        Label _subtitle = new Label();
        Persona _persona = new Persona() 
        { 
            Source = "persona.png" 
        };

        Icon _icon = new Icon() 
        { 
            Source = "Logo.svg" 
        };

        // BindableProperties
        public static readonly BindableProperty name = BindableProperty.Create(
           "Name", typeof(string), typeof(AppBar), "");


        public static readonly BindableProperty iconSource = BindableProperty.Create(
          "IconSource", typeof(string), typeof(Icon), "Logo.svg");

        public string IconSource
        {
            get { return (string)GetValue(AppBar.iconSource); }
            set
            {
                SetValue(AppBar.iconSource, value);
                _icon.Source = value;
            }
        }

        // Constructor
        public AppBar()
        {
            this.Padding = new Thickness(0, 0);
            this.Margin = new Thickness(0, 0);
            this.Content = _appBar;

            _persona.Padding = new Thickness(0);
            _persona.Margin = new Thickness(0);
            _persona.FrameSize = FrameSizes.M;
            _persona.BackgroundColor = Color.Transparent;

            _title = new Label()
            {
                Text = "Title",
                TextColor = _colors.White,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0, 0),
            };

            _subtitle = new Label()
            {
                Text = "Subtitle",
                TextColor = _colors.White,
                FontSize = 12,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0, 0),
            };

            _titles.Orientation = StackOrientation.Vertical;
            _titles.BackgroundColor = Color.Transparent;
            _titles.Spacing = 0;
            _titles.Children.Add(_title);
            _titles.Children.Add(_subtitle);
            _icon.Source = IconSource;
            _appBar.Orientation = StackOrientation.Horizontal;
            _appBar.BackgroundColor = Color.Transparent;
            _appBar.Spacing = 16;
            _appBar.BackgroundColor = _colors.ThemePrimary;
            _appBar.HorizontalOptions = LayoutOptions.FillAndExpand;
            _appBar.VerticalOptions = LayoutOptions.Start;
            _appBar.Padding = new Thickness(15, 15);
            _appBar.Margin = new Thickness(0);
            _appBar.Children.Add(_icon);
            _appBar.Children.Add(_titles);
        }
    }
}
