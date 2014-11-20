using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;


namespace XamarinFormsTests.Android
{
    [Activity (Label = "XamarinFormsTests.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate (savedInstanceState);

            Xamarin.Forms.Forms.Init (this, savedInstanceState);
            LoadApplication (new App ());
        }
    }
}

