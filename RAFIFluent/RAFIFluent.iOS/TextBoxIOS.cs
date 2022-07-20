using Foundation;
using component.xamarin.fluentui.FluentComponents;
using component.xamarin.fluentui.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(component.xamarin.fluentui.FluentComponents.TextBox), typeof(TextBoxIOS))]
namespace component.xamarin.fluentui.iOS
{
    public class TextBoxIOS : EntryRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.BorderColor = Color.Transparent.ToCGColor();
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }

    }
}