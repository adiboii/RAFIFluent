using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    internal class ImageButton : Frame
    {

        // Local Declarations
        int _Width;
        int _Height;

        // Bindable Properties
        public static readonly BindableProperty sizeType = BindableProperty.Create(
            "SizeType", typeof(SizeType), typeof(ImageButton), SizeType.R);

        // Getters and Setters
        public SizeType SizeType
        {
            get { return (SizeType)GetValue(ImageButton.sizeType); }
            set
            {
                SetValue(ImageButton.sizeType, value);
                if (value == SizeType.R)
                {
                    this._Width = 22;
                    this._Height = 22;
                }
                else if (value == SizeType.L)
                {
                    this._Width = 24;
                    this._Height = 24;
                }
            }
        }

        // Constructor
        public ImageButton()
        {
            WidthRequest = this._Width;
            HeightRequest = this._Height;
        }
      

    }
}

