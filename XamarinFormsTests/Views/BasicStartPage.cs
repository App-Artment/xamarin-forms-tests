using System;

using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class BasicStartPage : ContentPage
    {
        public BasicStartPage ()
        {
            InitPageContent ();
        }

        void InitPageContent()
        {
            var labelHeader = new Label {
                Text = "Xamarin Forms Tests",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var buttonStart = new Button {
                Text = "Tap here to start",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Content = new StackLayout {
                Children = {
                    labelHeader,
                    buttonStart
                }
            };

            buttonStart.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };
        }
    }
}

