using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class Chip : Frame
    {
        static FluentColor colors = new FluentColor();
        Image image = new Image();
        Label text = new Label();

        public static readonly BindableProperty label = BindableProperty.Create(
          "Label", typeof(string), typeof(Chip), "Hello");

        public string Label
        {
            get { return (string)GetValue(Chip.label); }
            set 
            { 
                SetValue(Chip.label, value); 
                text.Text = value;
            }
        }


        public static readonly BindableProperty textColor = BindableProperty.Create(
          "TextColor", typeof(Color), typeof(Chip), colors.NeutralDark);

        public Color TextColor
        {
            get { return (Color)GetValue(Chip.textColor); }
            set
            {
                SetValue(Chip.textColor, value);
                text.TextColor = value;
            }
        }


        public static readonly BindableProperty source = BindableProperty.Create(
          "Source", typeof(string), typeof(Chip), "profile.png");

        public string Source
        {
            get { return (string)GetValue(Chip.source); }
            set 
            { 
                SetValue(Chip.source, value); 
                image.Source = value;
            }
        }

        public Chip()
        {
            StackLayout stack = new StackLayout();
            stack.Spacing = 5;
            stack.Orientation = StackOrientation.Horizontal;
            stack.BackgroundColor = Color.Transparent;
            stack.VerticalOptions = LayoutOptions.Center;
            stack.HorizontalOptions = LayoutOptions.Center;

            image.WidthRequest = 15;
            image.HeightRequest = 15;
            image.VerticalOptions = LayoutOptions.Center;
            image.HorizontalOptions = LayoutOptions.Center;
            //Text.HorizontalOptions = LayoutOptions.Center;
            //Text.VerticalOptions = LayoutOptions.Center;
            //Text.FontAttributes = FontAttributes.Bold;

            stack.Children.Add(image);
            stack.Children.Add(text);
            //this.Text = Label;
            this.HorizontalOptions = LayoutOptions.Center;
            this.VerticalOptions = LayoutOptions.Center;
            this.Padding = new Thickness(5, 5);

            this.Content = stack;
        }
    }
}

// RAFIFluent
