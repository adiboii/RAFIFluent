using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RAFIFluent.FluentComponents
{

    // !To implement
    //As of now, there is no way to change the circle color
    //without having to use control templates, and there are 
    //not many documentations of it being used in C#

    public class RadioButton : Xamarin.Forms.RadioButton
    {
        FluentColor colors = new FluentColor();

        public RadioButton()
        {
            InitVisualStates();
        }
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
                                new Setter { Property = BorderColorProperty, Value = colors.ThemePrimary }
                            }
                        },
                        new VisualState
                        {
                            Name = "Unchecked",
                            TargetType = typeof(Xamarin.Forms.RadioButton),
                            Setters =
                            {
                                new Setter {Property = BorderColorProperty, Value = colors.ThemePrimary }
                            }

                        }
                    }
                }
            });
        }

    }
}
