using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace RAFIFluent.FluentComponents
{
    public class Toggle : Switch
    {
        FluentColor colors = new FluentColor();

        public Toggle()
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
                    TargetType=typeof(Switch),
                    States =
                    {
                        new VisualState
                        {
                            Name = "On",
                            TargetType = typeof(Switch),
                            Setters =
                            {
                               new Setter { Property = OnColorProperty, Value = colors.ThemeTertiary },
                               new Setter { Property = ThumbColorProperty, Value = colors.ThemePrimary }
                            }
                        },
                        new VisualState
                        {
                            Name = "Off",
                            TargetType = typeof(Switch),
                            Setters =
                            {
                               new Setter { Property = ThumbColorProperty, Value = colors.NeutralLight }
                            }

                        }
                    }
                }
            });
        }

    }

 
}
