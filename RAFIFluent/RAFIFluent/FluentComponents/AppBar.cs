using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FFImageLoading.Forms;
using FFImageLoading.Svg.Forms;

namespace RAFIFluent.FluentComponents
{
    internal class AppBar : Frame
    {
        // Local Declarations
        FluentColor colors = new FluentColor();
        StackLayout appBar = new StackLayout();
        StackLayout titles = new StackLayout();

        Label title;
        Label subtitle = new Label();
        Persona persona = new Persona()
        {
            Source = "persona.png",
        };

        Icon icon = new Icon()
        {
            Source = "Logo.svg"
        };

        public static readonly BindableProperty iconSource = BindableProperty.Create(
          "IconSource", typeof(string), typeof(Icon), "Logo.svg");

        public string IconSource
        {
            get { return (string)GetValue(AppBar.iconSource); }
            set
            {
                SetValue(AppBar.iconSource, value);
                icon.Source = value;
            }
        }

        // Constructor
        public AppBar()
        {
            this.Padding = new Thickness(0, 0);
            this.Margin = new Thickness(0, 0);
            this.Content = appBar;

            persona.Padding = new Thickness(0);
            persona.Margin = new Thickness(0);
            persona.FrameSize = FrameSizes.M;
            persona.BackgroundColor = Color.Transparent;

            title = new Label()
            {
                Text = "Title",
                TextColor = colors.White,
                FontSize = 20,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0, 0),
            };

            subtitle = new Label()
            {
                Text = "Subtitle",
                TextColor = colors.White,
                FontSize = 12,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Padding = new Thickness(0, 0),
            };

            titles.Orientation = StackOrientation.Vertical;
            titles.BackgroundColor = Color.Transparent;
            titles.Spacing = 0;
            titles.Children.Add(title);
            titles.Children.Add(subtitle);
            icon.Source = IconSource;
            appBar.Orientation = StackOrientation.Horizontal;
            appBar.BackgroundColor = Color.Transparent;
            appBar.Spacing = 16;
            appBar.BackgroundColor = colors.ThemePrimary;
            appBar.HorizontalOptions = LayoutOptions.FillAndExpand;
            appBar.VerticalOptions = LayoutOptions.Start;
            appBar.Padding = new Thickness(15, 15);
            appBar.Margin = new Thickness(0);
            appBar.Children.Add(icon);
            appBar.Children.Add(titles);
        }

        // BindableProperties
        public static readonly BindableProperty name = BindableProperty.Create(
           "Name", typeof(string), typeof(AppBar), "");
    }
}
