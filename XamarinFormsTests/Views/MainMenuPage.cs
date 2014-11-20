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
                "My Content Page",
                "Navigation Page",
                "Tab Page",
                "Startpage"
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

            listView.ItemSelected += delegate(object sender, SelectedItemChangedEventArgs e) {
                if (e.SelectedItem.Equals (listItems[0])) {
                    // Open My Content Page
                    Application.Current.MainPage = new MyContentPage();
                } else if (e.SelectedItem.Equals(listItems[1])) {
                    // Open My Navigation Page
                    Application.Current.MainPage = new NavigationPage(new MyNavigationPage());
                } else if (e.SelectedItem.Equals(listItems[3])) {
                    // Open Startpage
                    App.ShowStartPage();
                }
            };
        }
    }
}

