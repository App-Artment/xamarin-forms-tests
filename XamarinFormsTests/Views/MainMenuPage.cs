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
                Text = "Select a test",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            string[] listItems = {
                "Startpage",
                "Content Page",
                "Navigation Pages",
                "Font Family tests",
                "Controls"
            };

            var listView = new ListView {
                ItemsSource = listItems
            };

            Content = new StackLayout {
                Padding = new Thickness(0, 20, 0, 0),
                Children = {
                    labelHeader,
                    listView
                }
            };

            listView.ItemSelected += delegate(object sender, SelectedItemChangedEventArgs e) {
                if (e.SelectedItem.Equals(listItems[0])) {
                    // Open Startpage
                    App.ShowStartPage();
                } else if (e.SelectedItem.Equals (listItems[1])) {
                    // Open My Content Page
                    Application.Current.MainPage = new MyContentPage();
                } else if (e.SelectedItem.Equals(listItems[2])) {
                    // Open My Navigation Page
                    Application.Current.MainPage = new NavigationPage(new MyNavigationPage());
                } else if (e.SelectedItem.Equals(listItems[3])) {
                    // Font tests
                    Application.Current.MainPage = new NavigationPage(new FontTestPage());
                } else if (e.SelectedItem.Equals(listItems[4])) {
                    // Controls
                    Application.Current.MainPage = new NavigationPage(new ControlListPage());
                }
            };
        }
    }
}

