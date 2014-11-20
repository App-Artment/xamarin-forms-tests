using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class MainMenuPage : ContentPage
    {
        public MainMenuPage ()
        {
            InitPageContent ();
        }

        void InitPageContent()
        {
            var labelHeader = new Label {
                Text = "Select the page",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            string[] listItems = {
                "Content Page",
                "Navigation Page",
                "Tab Page"
            };

            var listView = new ListView {
                ItemsSource = listItems
            };

            Content = new StackLayout {
                Children = {
                    labelHeader,
                    listView
                }
            };
        }
    }
}

