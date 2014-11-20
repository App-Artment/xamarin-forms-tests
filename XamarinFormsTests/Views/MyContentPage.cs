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
                FontSize = 26,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var labelFontTestDefault = new Label {
                TextColor = Color.Gray,
                Text = "Font: Default, size=8",
                FontSize = 17,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
            };

            var labelFontTestHelvetica = new Label {
                TextColor = Color.Gray,
                Text = "Font: HelveticaNeue, size=8",
                FontFamily = "HelveticaNeue-Light",
                FontSize = 17,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
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
                    new StackLayout {
                        Children = {
                            labelFontTestDefault,
                            labelFontTestHelvetica,
                        },
                        VerticalOptions = LayoutOptions.StartAndExpand
                    },
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

