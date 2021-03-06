﻿using System;
using Xamarin.Forms;

namespace XamarinFormsTests.Views
{
    public class GridPage : ContentPage
    {
        Grid grid;

        public GridPage ()
        {
            grid = new Grid {
                Padding = new Thickness(5, 5),
                RowSpacing = 5,
                ColumnSpacing = 5,
                BackgroundColor = Color.Gray,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(80, GridUnitType.Absolute) }
                },
                ColumnDefinitions = {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            Content = grid;

            // Add the tiles
            CreateTile (0, Color.Yellow, 0, 0);
            CreateTile (1, Color.Red, 0, 1);
            CreateTile (2, Color.Green, 1, 0);
            CreateTile (3, Color.Blue, 1, 1);

            // Add a back to menu button
            var btnBackToMenu = new Button {
                Text = "Back to Menu",
                TextColor = Color.White
            };
            btnBackToMenu.Clicked += delegate {
                Application.Current.MainPage = new MainMenuPage();
            };
            grid.Children.Add (btnBackToMenu, 0, 2, 2, 3);
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

