using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace component.xamarin.fluentui.FluentComponents
{
    // !IMPORTANT! This does not work!
    // As of now, there is no way to change the circle color
    // without having to use control templates, and there are 
    // not many documentations of it being used in C#.

    public class RadioButton : Xamarin.Forms.RadioButton
    {
        // Local declarations
        FluentColor _colors = new FluentColor();

        // Constructor
        public RadioButton()
        {
            InitVisualStates();
        }

        // Methods

        // Changing default colors of radiobutton
        // using Visual States.
        void InitVisualStates()
        {
            VisualStateManager.SetVisualStateGroups(this, new VisualStateGroupList
            {
                new VisualStateGroup
                {
                    Name="CommonStates",
                    TargetType=typeof(RadioButton),
                    States =
                    {
                        new VisualState
                        {
                            Name = "Checked",
                            TargetType = typeof(Xamarin.Forms.RadioButton),
                            Setters =
                            {
                                new Setter { Property = BorderColorProperty, Value = _colors.ThemePrimary }
                            }
                        },
                        new VisualState
                        {
                            Name = "Unchecked",
                            TargetType = typeof(Xamarin.Forms.RadioButton),
                            Setters =
                            {
                                new Setter {Property = BorderColorProperty, Value = _colors.ThemePrimary }
                            }

                        }
                    }
                }
            });
        }

    }
}
