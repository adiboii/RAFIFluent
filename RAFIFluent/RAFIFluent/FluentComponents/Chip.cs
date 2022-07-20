using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{

    // TODO: Implement gesture detector 
    public class Chip : Frame
    {
        // Local Declarations
        Image _image = new Image();
        Label _text = new Label();
        StackLayout _stack = new StackLayout();

        // Bindable Properties + Getters and Setters
        public static readonly BindableProperty label = BindableProperty.Create(
          "Label", typeof(string), typeof(Chip), "Hello");

        public string Label
        {
            get { return (string)GetValue(Chip.label); }
            set 
            { 
                SetValue(Chip.label, value); 
                _text.Text = value;
            }
        }

        public static readonly BindableProperty textColor = BindableProperty.Create(
          "TextColor", typeof(Color), typeof(Chip), Color.Black);

        public Color TextColor
        {
            get { return (Color)GetValue(Chip.textColor); }
            set
            {
                SetValue(Chip.textColor, value);
                _text.TextColor = value;
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
                _image.Source = value;
            }
        }

        //Constructor
        public Chip()
        {
            this.HorizontalOptions = LayoutOptions.Center;
            this.VerticalOptions = LayoutOptions.Center;
            this.Padding = new Thickness(5, 5);
            
            _stack.Spacing = 5;
            _stack.Orientation = StackOrientation.Horizontal;
            _stack.BackgroundColor = Color.Transparent;
            _stack.VerticalOptions = LayoutOptions.Center;
            _stack.HorizontalOptions = LayoutOptions.Center;

            _image.WidthRequest = 15;
            _image.HeightRequest = 15;
            _image.VerticalOptions = LayoutOptions.Center;
            _image.HorizontalOptions = LayoutOptions.Center;

            _stack.Children.Add(_image);
            _stack.Children.Add(_text);

            this.Content = _stack;
        }
    }
}