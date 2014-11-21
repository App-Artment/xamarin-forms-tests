using System;
using System.ComponentModel;

namespace XamarinFormsTests.ViewModels
{
    public class LabelControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string FontFamily { get; set; }

        private string text;
        private double fontSize;

        public LabelControlViewModel ()
        {
            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam vel placerat justo. Fusce facilisis lectus id dui luctus aliquet ac a ligula.";
            FontSize = 14;
            FontFamily = "Verdana";
        }

        public string Text { 
            get {
                return text;
            }
            set {
                if (text == value)
                    return;

                text = value;

                if (PropertyChanged != null)
                    PropertyChanged (this, new PropertyChangedEventArgs ("Text"));
            }
        }


        public double FontSize { 
            get {
                return fontSize;
            }
            set {
                if (fontSize == value)
                    return;

                fontSize = value;
                if (PropertyChanged != null)
                    PropertyChanged (this, new PropertyChangedEventArgs ("FontSize"));
            }
        }

    }
}

