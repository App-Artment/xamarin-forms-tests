using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class SliderControlPage : ContentPage
    {
        public SliderControlPage ()
        {
            InitPageContent ();
        }

        void InitPageContent()
        {
            var slider = new Slider {

            };

            Content = new StackLayout {
                Children = {
                    slider
                }
            };
        }
    }
}

