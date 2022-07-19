using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace RAFIFluent.FluentComponents
{
    public class Toggle : Switch
    {
        //Local Decalarations
        static FluentColor colors = new FluentColor();


        //Bindable Properties + Getters and Setters
        public static readonly BindableProperty activeThumbColor = BindableProperty.Create(
         "ActiveThumbColor", typeof(Color), typeof(Chip), colors.ThemePrimary);

        public Color ActiveThumbColor
        {
            get { return (Color)GetValue(Toggle.activeThumbColor); }
            set { SetValue(Toggle.activeThumbColor, value); }
        }


        public static readonly BindableProperty inactiveThumbColor = BindableProperty.Create(
       "InactiveThumbColor", typeof(Color), typeof(Chip), colors.NeutralLight);

        public Color InactiveThumbColor
        {
            get { return (Color)GetValue(Toggle.inactiveThumbColor); }
            set { SetValue(Toggle.inactiveThumbColor, value); }
        }


        public static readonly BindableProperty activeOnColor = BindableProperty.Create(
       "ActiveOnColor", typeof(Color), typeof(Chip), colors.ThemeTertiary);

        public Color ActiveOnColor
        {
            get { return (Color)GetValue(Toggle.activeOnColor); }
            set 
            { SetValue(Toggle.activeOnColor, value); }
        }


        //Constructor 
        public Toggle()
        {
            InitVisualStates();   
        }

        // Changing default colors of switch
        void InitVisualStates()
        {
            VisualStateManager.SetVisualStateGroups(this, new VisualStateGroupList
            {
                new VisualStateGroup
                {
                    Name="CommonStates",
                    TargetType=typeof(Switch),
                    States =
                    {
                        new VisualState
                        {
                            Name = "On",
                            TargetType = typeof(Switch),
                            Setters =
                            {
                               new Setter { Property = OnColorProperty, Value =  ActiveOnColor},
                               new Setter { Property = ThumbColorProperty, Value = ActiveThumbColor }
                            }
                        },
                        new VisualState
                        {
                            Name = "Off",
                            TargetType = typeof(Switch),
                            Setters =
                            {
                               new Setter { Property = ThumbColorProperty, Value = InactiveThumbColor }
                            }

                        }
                    }
                }
            });
        }


    }
}
