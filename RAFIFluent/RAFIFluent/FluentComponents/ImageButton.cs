using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    internal class ImageButton : Frame
    {
        // Constructor
        int Width;
        int Height;
        public ImageButton()
        {
            this.Width = 22;
            this.Height = 22;

        }
        // Bindable Properties
        public static readonly BindableProperty sizeType = BindableProperty.Create(
            "SizeType", typeof(char), typeof(ImageButton), 'R');
        // R : Regular
        // L : Large

        // Getters and Setters
        public char SizeType
        {
            get { return (char)GetValue(ImageButton.sizeType); }
            set
            {
                SetValue(ImageButton.sizeType, value);
                if (value == 'R')
                {
                    this.Width = 22;
                    this.Height = 22;
                }
                else if (value == 'L')
                {
                    this.Width = 24;
                    this.Height = 24;
                }
            }
        }

    }
}

