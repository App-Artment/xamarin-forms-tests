using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class ControlListPage : ContentPage
    {
        public ControlListPage ()
        {
            InitPageContent ();

            ToolbarItems.Add (new ToolbarItem (
                "Back to menu", 
                null, 
                () => { Application.Current.MainPage = new MainMenuPage(); }, 
                ToolbarItemOrder.Primary)
            );
        }

        void InitPageContent()
        {
            string[] items = {
                "Slider"
            };

            var list = new ListView {
                ItemsSource = items,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Content = list;

            list.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
                if (e.SelectedItem.Equals(items[0])) {
                    // Slider
                    Navigation.PushAsync(new SliderControlPage());
                }
            };
        }
    }
}

