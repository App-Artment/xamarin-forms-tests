using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamarinFormsTests.iOS
{
    [Register ("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            Forms.Init ();

            LoadApplication (new App ());

            return base.FinishedLaunching (uiApplication, launchOptions);
        }
    }
}

