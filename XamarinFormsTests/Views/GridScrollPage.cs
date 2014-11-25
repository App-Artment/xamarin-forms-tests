using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class GridScrollPage : ContentPage
    {
        Grid grid;

        public GridScrollPage ()
        {
            grid = new Grid {
                Padding = new Thickness(5, 5),
                RowSpacing = 5,
                ColumnSpacing = 5,
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(200, GridUnitType.Absolute) },
                    new RowDefinition { Height = new GridLength(80, GridUnitType.Absolute) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            Content = new ScrollView
            {
                BackgroundColor = Color.Maroon,
                Content = grid,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            // Add the tiles
            CreateTile (0, Color.Blue, 0, 0);
            CreateTile (1, Color.Green, 1, 0);
            CreateTile (2, Color.Green, 0, 1);
            CreateTile (3, Color.Blue, 1, 1);
            CreateTile (4, Color.Blue, 0, 2);
            CreateTile (5, Color.Green, 1, 2);
            CreateTile (6, Color.Green, 0, 3);
            CreateTile (7, Color.Blue, 1, 3);

            // Add a back to menu button
            var btnBackToMenu = new Button {
                Text = "Back to Menu",
                TextColor = Color.White
            };
            btnBackToMenu.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };
            grid.Children.Add (btnBackToMenu, 0, 2, 4, 5);
        }

        void CreateTile(int index, Color color, int left, int top)
        {
            var tile = new RelativeLayout ();
            tile.Children.Add(
                new BoxView { BackgroundColor = color },
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent(p => p.Width),
                Constraint.RelativeToParent(p => p.Height)
            );
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

