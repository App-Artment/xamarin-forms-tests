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

        public MyNavigationPage (int step) : base()
        {
            currentStep = step;

            InitPageContent ();
        }

        void InitPageContent()
        {
            ToolbarItems.Add (new ToolbarItem (
                "Back to menu", 
                null, 
                () => { Application.Current.MainPage = new MainMenuPage(); }, 
                ToolbarItemOrder.Primary)
            );

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

            Content = new StackLayout {
                Padding = new Thickness (0, 40, 0, 0),
                Children = {
                    labelHeader,
                    labelCurrentStep,
                    buttonOpenNextPage
                }
            };

            buttonOpenNextPage.Clicked += delegate {
                Navigation.PushAsync(new MyNavigationPage(currentStep + 1));
            };
        }
    }
}

