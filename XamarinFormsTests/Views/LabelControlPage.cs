using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class LabelControlPage : ContentPage
    {
        readonly ViewModels.LabelControlViewModel viewModel;

        public LabelControlPage ()
        {
            BindingContext = viewModel = new ViewModels.LabelControlViewModel ();

            InitPageContent ();
        }

        void InitPageContent()
        {
            var entryText = new Entry {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            entryText.SetBinding (Entry.TextProperty, "Text");

            var btnFontSize8 = new Button {
                Text = "8"
            };
            var btnFontSize14 = new Button {
                Text = "14"
            };
            var btnFontSize18 = new Button {
                Text = "18"
            };

            var labelText = new Label {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.StartAndExpand,
                BackgroundColor = Color.FromHex("f3f3f3")
            };
            labelText.SetBinding (Label.TextProperty, "Text");
            labelText.SetBinding (Label.FontSizeProperty, "FontSize");

            Content = new StackLayout {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = {
                    entryText,
                    new StackLayout {
                        Orientation = StackOrientation.Horizontal,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        Children = {
                            new Label { Text = "Font size:", VerticalOptions = LayoutOptions.Center },
                            btnFontSize8,
                            btnFontSize14,
                            btnFontSize18
                        }
                    },
                    labelText
                }
            };

            btnFontSize8.Clicked += delegate {
                viewModel.FontSize = 8;
            };

            btnFontSize14.Clicked += delegate {
                viewModel.FontSize = 14;
            };

            btnFontSize18.Clicked += delegate {
                viewModel.FontSize = 18;
            };
        }
    }
}

