using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
        //Image persona = new Image();
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

            appBar.Orientation = StackOrientation.Horizontal;
            appBar.BackgroundColor = Color.Transparent;
            appBar.Spacing = 16;
            appBar.BackgroundColor = colors.ThemePrimary;
            appBar.HorizontalOptions = LayoutOptions.FillAndExpand;
            appBar.VerticalOptions = LayoutOptions.Start;
            appBar.Padding = new Thickness(15, 15);
            appBar.Margin = new Thickness(0);
            appBar.Children.Add(persona);
            appBar.Children.Add(titles);
        }

        // BindableProperties
        public static readonly BindableProperty name = BindableProperty.Create(
           "Name", typeof(string), typeof(AppBar), "");
    }
}
