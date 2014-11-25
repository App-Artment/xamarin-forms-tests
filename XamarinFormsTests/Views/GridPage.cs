using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class GridPage : ContentPage
    {
        Grid grid;

        public GridPage ()
        {
            grid = new Grid {
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            CreateTile (0, Color.Yellow, 0, 0);
            CreateTile (1, Color.Red, 0, 1);
            CreateTile (2, Color.Green, 1, 0);
            CreateTile (3, Color.Blue, 1, 1);

            var btnBackToMenu = new Button {
                Text = "Back to Menu",
                TextColor = Color.White
            };
            btnBackToMenu.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };
            grid.Children.Add (btnBackToMenu, 0, 2, 2, 3);

            Content = grid;
        }

        void CreateTile(int index, Color color, int left, int top)
        {
            var tile = new BoxView {
                BackgroundColor = color,
            };
            var tileTap = new TapGestureRecognizer ();
            tileTap.Tapped += delegate { 
                System.Diagnostics.Debug.WriteLine (
                    String.Format ("Tile index {0} tapped!", index));
            };
            tile.GestureRecognizers.Add (tileTap);
            grid.Children.Add (tile, left, top);
        }
    }
}

