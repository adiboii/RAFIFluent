using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace component.xamarin.fluentui.FluentComponents
{
    public class Persona : Frame
    {
        // Constants
        FluentColor _colors = new FluentColor();
        Label _initials = new Label();
        Image _picture = new Image();

        // Properties/Indexers
        public static readonly BindableProperty frameSize = BindableProperty.Create(
            "FrameSize", typeof(FrameSizes), typeof(Persona), FrameSizes.M);

        public static readonly BindableProperty name = BindableProperty.Create(
            "Name", typeof(string), typeof(Persona), "");

        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(Persona), false);

        public static readonly BindableProperty source = BindableProperty.Create(
            "Source", typeof(string), typeof(Persona), "");

        public FrameSizes FrameSize
        {
            get { return (FrameSizes)GetValue(frameSize); }
            set
            {
                SetValue(frameSize, value);
                switch (value)
                {
                    case FrameSizes.XS:
                        HeightRequest = 20;
                        WidthRequest = 20;
                        break;
                    case FrameSizes.S:
                        HeightRequest = 24;
                        WidthRequest = 24;
                        break;
                    case FrameSizes.M:
                        HeightRequest = 32;
                        WidthRequest = 32;
                        break;
                    case FrameSizes.L:
                        HeightRequest = 40;
                        WidthRequest = 40;
                        break;
                    case FrameSizes.XL:
                        HeightRequest = 52;
                        WidthRequest = 52;
                        break;
                    case FrameSizes.XXL:
                        HeightRequest = 64;
                        WidthRequest = 64;
                        break;
                    default:
                        HeightRequest = 32;
                        WidthRequest = 32;
                        break;
                }
            }
        }

        public string Name
        {
            get { return (string)GetValue(name); }
            set
            {
                SetValue(name, value);
                if (value == string.Empty)
                    _initials.Text = string.Empty;
                else
                {
                    string firstName = string.Empty;
                    string lastName = string.Empty;

                    string[] words = value.Split(' ');

                    if (IsRomanNumeral(words[words.Length - 1]) ||
                        words[words.Length - 1].Equals("Jr.") ||
                        words[words.Length - 1].Equals("Sr.")
                        )
                        Array.Resize(ref words, words.Length - 1);

                    if (words[0].Contains(","))
                    {
                        lastName = words[0].Substring(0, words[0].Length - 2);
                        firstName = words[1];
                    }
                    else
                    {
                        firstName = words[0].ToString();
                        lastName = words[words.Length - 1];
                    }

                    string inits = firstName[0].ToString() + lastName[0].ToString();

                    _initials.Text = inits;
                    _initials.TextTransform = TextTransform.Uppercase;
                    _initials.HorizontalOptions = LayoutOptions.Center;
                    _initials.VerticalOptions = LayoutOptions.Center;
                }
                Content = _initials;
            }
        }

        public bool DarkMode
        {
            get { return (bool)GetValue(darkMode); }
            set
            {
                SetValue(darkMode, value);
                if (value)
                    _initials.TextColor = _colors.Black;
                else if (!value)
                    _initials.TextColor = _colors.White;
            }
        }

        public string Source
        {
            get { return (string)GetValue(source); }
            set
            {
                SetValue(source, value);
                if (value != "")
                {
                    _picture.Source = value;
                    Content = _picture;
                }
            }
        }

        // Constructors
        public Persona()
        {
            CornerRadius = 100;
            HeightRequest = 32;
            WidthRequest = 32;
            HorizontalOptions = LayoutOptions.Center;
            Padding = 0;
            IsClippedToBounds = true;
            BackgroundColor = _colors.ThemePrimary;
            _initials.TextColor = _colors.White;
            _initials.Text = string.Empty;
        }

        // Methods 
        public bool IsRomanNumeral(string word)
        {
            // "previousValue" is initialized to 1001
            // since the largest value of a Roman numeral
            // character is 1000.
            int previousValue = 1001;

            // "previousChar" is initialized to 'A'
            // since 'A' is not a Roman numeral character.
            char previousChar = 'A';
            // Succeeding number of occurrences of the previous character.
            int nPreviousChar = 0; 

            foreach (char c in word)
            {
                // Return "false" if the character being
                // traversed is not a Roman numeral
                // character.
                if (GetRomanNumeralValue(c) == 0)
                    return false;

                if (previousChar == c)
                    nPreviousChar++;

                // Roman numerals must not have four (4)
                // succeeding characters that are the same.
                if (nPreviousChar == 4)
                    return false;

                if (GetRomanNumeralValue(c) > previousValue)
                {
                    // Subtractive Notation.
                    switch (c)
                    {
                        case 'V':
                        case 'X':
                            if (previousChar == 'I')
                                break;
                            else
                                return false;
                        case 'L':
                        case 'C':
                            if (previousChar == 'X')
                                break;
                            else
                                return false;
                        case 'D':
                        case 'M':
                            if (previousChar == 'C')
                                break;
                            else
                                return false;
                    }
                }

                previousChar = c;
            }
            return true;
        }

        public int GetRomanNumeralValue(char c)
        {
            int value = 0;
            switch (c)
            {
                case 'I':
                    value = 1;
                    break;
                case 'V':
                    value = 5;
                    break;
                case 'X':
                    value = 10;
                    break;
                case 'L':
                    value = 50;
                    break;
                case 'C':
                    value = 100;
                    break;
                case 'D':
                    value = 500;
                    break;
                case 'M':
                    value = 1000;
                    break;
                default:
                    value = 0;
                    break;
            }
            return value;
        }
    }
}
