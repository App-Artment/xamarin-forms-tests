using System;
using Xamarin.Forms;

namespace XamarinFormsTests
{
    public class App : Application
    {
        public App()
        {
            MainPage = new Views.BasicStartPage ();
        }

        public static Page GetMainPage()
        {    
            return new ContentPage { 
                Content = new Label {
                    Text = "Hello, Forms!",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}

