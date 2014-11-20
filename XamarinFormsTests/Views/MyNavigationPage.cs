using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class MyNavigationPage : ContentPage
    {
        int currentStep = 1;

        public MyNavigationPage ()
        {
            InitPageContent ();
        }

        public MyNavigationPage (int step)
        {
            currentStep = step;

            InitPageContent ();
        }

        void InitPageContent()
        {
            var labelHeader = new Label {
                Text = "My Navigation Page",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var labelCurrentStep = new Label {
                Text = String.Format("Current step: {0}", currentStep),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var buttonOpenNextPage = new Button {
                Text = String.Format ("Open next step ({0})", currentStep + 1),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            var buttonBackToMainMenu = new Button {
                Text = "Back to main menu",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };


            Content = new StackLayout {
                Padding = new Thickness (0, 40, 0, 0),
                Children = {
                    labelHeader,
                    labelCurrentStep,
                    buttonOpenNextPage,
                    buttonBackToMainMenu
                }
            };

            buttonOpenNextPage.Clicked += delegate {
                this.Navigation.PushAsync(new MyNavigationPage(currentStep + 1));
            };

            buttonBackToMainMenu.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };
        }
    }
}

