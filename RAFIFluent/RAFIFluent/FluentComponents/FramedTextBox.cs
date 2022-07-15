using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace RAFIFluent.FluentComponents
{
    public class FramedTextBox : Xamarin.Forms.Frame
    {
        FluentColor colors = new FluentColor();
        TextBox textbox = new TextBox();
        Icon icon = new Icon();

        public static readonly BindableProperty placeHolder = BindableProperty.Create(
           "PlaceHolder", typeof(string), typeof(FramedTextBox), "Search");
        public string PlaceHolder 
        { 
            get { return (string)GetValue(FramedTextBox.placeHolder); }
            set 
            { 
                SetValue(FramedTextBox.placeHolder, value);
                textbox.Placeholder = value;
            } 
        }

        public static readonly BindableProperty hasIcon = BindableProperty.Create(
            "HasIcon", typeof(bool), typeof(FramedTextBox), false);

        public bool HasIcon 
        { 
            get { return (bool)GetValue(FramedTextBox.hasIcon); } 
            set { SetValue(FramedTextBox.hasIcon, value); }
        }

        public static readonly BindableProperty textColor = BindableProperty.Create(
         "TextColor", typeof(Color), typeof(FramedTextBox), Color.Black);

        public Color TextColor
        {
            get { return (Color)GetValue(FramedTextBox.textColor); }    
            set 
            { 
                SetValue(FramedTextBox.textColor, value);
                textbox.TextColor = value;
            }
        }

        public static readonly BindableProperty placeholderColor = BindableProperty.Create(
        "PlaceholderColor", typeof(Color), typeof(FramedTextBox), Color.Black);

        public Color PlaceholderColor
        {
            get { return (Color)GetValue(FramedTextBox.placeholderColor); }
            set 
            { 
                SetValue(FramedTextBox.placeholderColor, value);
                textbox.PlaceholderColor = value;
            }
        }

        public static readonly BindableProperty iconSource = BindableProperty.Create(
          "IconSource", typeof(string), typeof(Icon), "Logo.svg");

        public string IconSource
        {
            get { return (string)GetValue(Icon.iconSource); }
            set 
            { 
                SetValue(Icon.iconSource, value); 
                icon.Source = value;
            }
        }

        public FramedTextBox()
        {
            BackgroundColor = colors.NeutralLight;
            Padding = new Thickness(10, 0);
            Margin = new Thickness(0);

            StackLayout stack = new StackLayout();
            stack.Spacing = 5;
            stack.Orientation = StackOrientation.Horizontal;
            textbox.FontSize = 14;
            textbox.HorizontalOptions = LayoutOptions.FillAndExpand;
            textbox.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;
            //image to add later
            icon.IconSource = IconSource;
            icon.HeightRequest = 20;
            icon.WidthRequest = 20;
            stack.Children.Add(icon);
            stack.Children.Add(textbox);
            Content = stack;
        }
    }
}
