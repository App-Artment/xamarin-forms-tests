using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class FontTestPage : ContentPage
    {
        private ViewModels.FontTestViewModel viewModel;

        public FontTestPage ()
        {
            BindingContext = viewModel = new ViewModels.FontTestViewModel ();

            InitPageContent ();
        }

        void InitPageContent()
        {
            var labelDemoText = new Label {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque a accumsan mauris. In hac habitasse platea dictumst. Sed et ante.",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start
            };
            labelDemoText.SetBinding(Label.FontFamilyProperty, "FontFamily");
            labelDemoText.SetBinding(Label.FontSizeProperty, "FontSize");

            var inputFontFamily = new Entry {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            inputFontFamily.SetBinding (Entry.TextProperty, "FontFamily");

            var sliderFontSize = new Slider (4, 32, 12) {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            sliderFontSize.SetBinding (Slider.ValueProperty, "FontSize");


            Content = new StackLayout {
                Padding = new Thickness(20, 20),
                Children = {
                    inputFontFamily,
                    sliderFontSize,
                    labelDemoText
                }
            };

        }

    }
}

