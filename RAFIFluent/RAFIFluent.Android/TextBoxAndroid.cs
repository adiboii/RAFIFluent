using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using component.xamarin.fluentui.Droid;
using component.xamarin.fluentui.FluentComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(component.xamarin.fluentui.FluentComponents.TextBox), typeof(TextBoxAndroid))]
namespace component.xamarin.fluentui.Droid
{
    public class TextBoxAndroid : EntryRenderer
    {
        public TextBoxAndroid(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}