using System;
using Xamarin.Forms;

namespace XamarinFormsTests
{
    public class App : Application
    {
        private static Views.BasicStartPage startPage;

        public App()
        {
            MainPage = startPage = new Views.BasicStartPage ();
        }

        public static void ShowStartPage()
        {
            Application.Current.MainPage = startPage;
        }

    }
}

