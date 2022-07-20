using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{
    public class CheckBox : Xamarin.Forms.CheckBox
    {
        // Local Decalarations
        FluentColor _colors = new FluentColor();

        // Constructor
        public CheckBox()
        {
            InitVisualStates();
        }


        //Methods

        // Changing default colors of checkbox
        // using Visual States.
        void InitVisualStates()
        {
            VisualStateManager.SetVisualStateGroups(this, new VisualStateGroupList
            {
                new VisualStateGroup
                {
                    Name="CommonStates",
                    TargetType=typeof(CheckBox),
                    States =
                    {
                        new VisualState
                        {   
                            Name = "Normal",
                            TargetType = typeof(Xamarin.Forms.CheckBox),
                            Setters =
                            {
                                new Setter {Property = ColorProperty, Value = _colors.NeutralTertiaryAlt }
                            }
                        },
                        new VisualState
                        {
                            Name = "IsChecked",
                            TargetType = typeof(Xamarin.Forms.CheckBox),
                            Setters =
                            {
                                new Setter { Property = ColorProperty , Value = _colors.ThemePrimary }
                            }

                        }
                    }
                }
            });
        }
    }
}

