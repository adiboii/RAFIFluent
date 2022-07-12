using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class Persona : Frame
    {
        // Legend:
        //  Course of Action (COA)
        //
        // To-Do List | FluentPersona
        // 1. Name Attribute
        //    1.A. Situation: "Name" has already been initialized
        //         COA: Erase "Name" attribute
        //         Problem: Initials are still displayed
        //    2.A. 

        // Local Declarations
        FluentColor colors = new FluentColor();
        Label initials = new Label();
        Image picture = new Image();

        // Constructor
        public Persona()
        {
            CornerRadius = 100;
            HeightRequest = 32;
            WidthRequest = 32;
            HorizontalOptions = LayoutOptions.Center;
            Padding = 0;
            IsClippedToBounds = true;
            BackgroundColor = colors.ThemePrimary;
            initials.TextColor = colors.White;
            initials.Text = string.Empty;
        }

        // Bindable Properties
        public static readonly BindableProperty frameSize = BindableProperty.Create(
            "FrameSize", typeof(FrameSizes), typeof(Persona), FrameSizes.M);

        public static readonly BindableProperty name = BindableProperty.Create(
            "Name", typeof(string), typeof(Persona), "");

        public static readonly BindableProperty darkMode = BindableProperty.Create(
            "DarkMode", typeof(bool), typeof(Persona), false);

        public static readonly BindableProperty source = BindableProperty.Create(
            "Source", typeof(string), typeof(Persona), "");

        // Getters and Setters
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
                    initials.Text = string.Empty;
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

                    initials.Text = inits;
                    initials.TextTransform = TextTransform.Uppercase;
                    initials.HorizontalOptions = LayoutOptions.Center;
                    initials.VerticalOptions = LayoutOptions.Center;
                }
                Content = initials;
            }
        }
        public bool DarkMode
        {
            get { return (bool)GetValue(darkMode); }
            set
            {
                SetValue(darkMode, value);
                if (value)
                    initials.TextColor = colors.Black;
                else if (!value)
                    initials.TextColor = colors.White;
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
                    picture.Source = value;
                    Content = picture;
                }
            }
        }

        // Functions
        public bool IsRomanNumeral(string word)
        {
            // "previousValue" is initialized to 1001
            // since the largest value of a Roman numeral
            // character is 1000
            int previousValue = 1001;

            // "previousChar" is initialized to 'A'
            // since 'A' is not a Roman numeral character
            char previousChar = 'A';
            int nPreviousChar = 0; // Succeeding number of occurrences of the previous character

            foreach (char c in word)
            {
                // Return "false" if the character being
                // traversed is not a Roman numeral
                // character
                if (GetRomanNumeralValue(c) == 0)
                    return false;

                if (previousChar == c)
                    nPreviousChar++;

                // Roman numerals must not have four (4)
                // succeeding characters that are the same
                if (nPreviousChar == 4)
                    return false;

                if (GetRomanNumeralValue(c) > previousValue)
                {
                    // Subtractive Notation
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
