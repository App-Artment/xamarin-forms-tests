using System;
using System.ComponentModel;

namespace XamarinFormsTests.ViewModels
{
    public class FontTestViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string fontFamily;
        private double fontSize;

        public FontTestViewModel ()
        {
            fontFamily = "HelveticaNeue-Thin";
            fontSize = 14;
        }

        public string FontFamily {
            get {
                return fontFamily;
            }
            set {
                if (fontFamily == value)
                    return;

                fontFamily = value;
                if (PropertyChanged != null) {
                    PropertyChanged (this, new PropertyChangedEventArgs ("FontFamily"));
                }
            }
        }

        public double FontSize {
            get {
                return fontSize;
            }
            set {
                fontSize = (double)Math.Round(value, 0);
                if (PropertyChanged != null) {
                    PropertyChanged (this, new PropertyChangedEventArgs ("FontSize"));
                }
            }
        }
    }
}

