using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace XamarinFormsTests
{
    public class App : Application
    {
        public static Views.BasicStartPage StartPage;
        public static Views.MainMenuPage MenuPage { get; set; }

        public App()
        {
            MainPage = StartPage = new Views.BasicStartPage ();
        }

        public static void ShowStartPage()
        {
            Application.Current.MainPage = StartPage;
        }

    }
}

