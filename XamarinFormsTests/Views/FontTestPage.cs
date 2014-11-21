using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class FontTestPage : ContentPage
    {
        public FontTestPage ()
        {
            BindingContext = new ViewModels.FontTestViewModel ();

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
            var labelDemoText = new Label {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vel placerat justo. Fusce facilisis lectus id dui luctus aliquet ac a ligula. Integer pellentesque nisl et orci porttitor, eget venenatis ligula varius. Donec in nunc a quam efficitur scelerisque id id erat. Phasellus sit amet orci et ipsum lobortis faucibus.<<END>>",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.FromHex("f3f3f3")
            };
            labelDemoText.SetBinding(Label.FontFamilyProperty, "FontFamily");
            labelDemoText.SetBinding(Label.FontSizeProperty, "FontSize");

            var inputFontFamily = new Entry {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            inputFontFamily.SetBinding (Entry.TextProperty, "FontFamily");

//            var sliderFontSize = new Slider (4, 32, 12) {
//                HorizontalOptions = LayoutOptions.FillAndExpand
//            };
//            sliderFontSize.SetBinding (Slider.ValueProperty, "FontSize");

            var entryFontSize = new Entry {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            entryFontSize.SetBinding (Entry.TextProperty, "FontSize");



            Content = new StackLayout {
                Padding = new Thickness(20, 20),
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = {
                    inputFontFamily,
                    entryFontSize,
                    labelDemoText
                }
            };

        }

    }
}

