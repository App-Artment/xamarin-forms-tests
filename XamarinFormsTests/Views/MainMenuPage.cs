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

        private static MasterDetailNavigation _masterDetailHost;
        public static MasterDetailNavigation MasterDetailHost 
        {
            get {
                if (_masterDetailHost == null)
                    _masterDetailHost = new MasterDetailNavigation ();
                return _masterDetailHost;
            }
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
                "Grid page",
                "Grid scroll page",
                "Font Family tests",
                "Controls",
                "MasterDetail Navigation",
                "MasterDetail Navigation ->> Page 1",
                "MasterDetail Navigation ->> Page 2",
                "MasterDetail Navigation ->> Page 3"
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
                if (e.SelectedItem == null)
                    return;

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
                    // Grid page
                    Application.Current.MainPage = new GridPage();
                } else if (e.SelectedItem.Equals(listItems[4])) {
                    // Grid scroll page
                    Application.Current.MainPage = new GridScrollPage();
                } else if (e.SelectedItem.Equals(listItems[5])) {
                    // Font tests
                    Application.Current.MainPage = new NavigationPage(new FontTestPage());
                } else if (e.SelectedItem.Equals(listItems[6])) {
                    // Controls
                    Application.Current.MainPage = new NavigationPage(new ControlListPage());
                } else if (e.SelectedItem.Equals(listItems[7])) {
                    // MasterDetail Navigation
                    Application.Current.MainPage = MasterDetailHost;
                } else if (e.SelectedItem.Equals(listItems[8]) || e.SelectedItem.Equals(listItems[9]) || e.SelectedItem.Equals(listItems[10])) {
                    // MasterDetail Navigation - direct page open
                    var item = e.SelectedItem.ToString();
                    var index = int.Parse(item.Substring(item.Length - 1)) - 1;
                    Application.Current.MainPage = MasterDetailHost;
                    MasterDetailHost.OpenPage(index);
                }

                listView.SelectedItem = null;
            };
        }
    }
}

