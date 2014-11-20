using System;

using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage ()
        {
            InitPageContent ();
        }

        void InitPageContent()
        {
            var labelHeader = new Label {
                Text = "My Content Page",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var buttonBackToMainMenu = new Button {
                Text = "Back to main menu",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var buttonBackToStartPage = new Button {
                Text = "Back to startpage",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout {
                Padding = new Thickness(0, 40, 0, 0),
                Children = {
                    labelHeader,
                    buttonBackToMainMenu,
                    buttonBackToStartPage
                }
            };

            buttonBackToMainMenu.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };

            buttonBackToStartPage.Clicked += delegate {
                App.ShowStartPage();
            };
        }
    }
}

