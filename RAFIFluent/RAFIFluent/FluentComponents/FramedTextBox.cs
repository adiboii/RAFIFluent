using FFImageLoading.Svg.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace component.xamarin.fluentui.FluentComponents
{

    //FramedTextBox is an icon and textbox
    //in a stacklayout enclosed in a frame.
    public class FramedTextBox : Xamarin.Forms.Frame
    {

        // Local Declarations
        FluentColor _colors = new FluentColor();
        StackLayout _stack = new StackLayout();
        TextBox _textbox = new TextBox();
        Icon _icon = new Icon();

        // Bindable Properties + Getters and Setters

        public static readonly BindableProperty placeHolder = BindableProperty.Create(
           "PlaceHolder", typeof(string), typeof(FramedTextBox), "Search");
        public string PlaceHolder 
        { 
            get { return (string)GetValue(FramedTextBox.placeHolder); }
            set 
            { 
                SetValue(FramedTextBox.placeHolder, value);
                _textbox.Placeholder = value;
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
                _textbox.TextColor = value;
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
                _textbox.PlaceholderColor = value;
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
                _icon.Source = value;
            }
        }

        
        // Constructor
        public FramedTextBox()
        {
            this.BackgroundColor = _colors.NeutralLight;
            this.Padding = new Thickness(10, 0);
            this.Margin = new Thickness(0);

            _stack.Spacing = 5;
            _stack.Orientation = StackOrientation.Horizontal;

            _textbox.FontSize = 14;
            _textbox.HorizontalOptions = LayoutOptions.FillAndExpand;
            _textbox.ClearButtonVisibility = ClearButtonVisibility.WhileEditing;

            _icon.IconSource = IconSource;
            _icon.HeightRequest = 20;
            _icon.WidthRequest = 20;

            _stack.Children.Add(_icon);
            _stack.Children.Add(_textbox);

            this.Content = _stack;
        }
    }
}
