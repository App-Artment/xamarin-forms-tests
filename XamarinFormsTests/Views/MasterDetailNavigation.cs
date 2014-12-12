using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace XamarinFormsTests.Views
{
    public class MasterDetailNavigation : MasterDetailPage
    {
		private List<NavigationPage> Pages;

        public MasterDetailNavigation ()
        {
            InitPages ();

            var menuList = new ListView {
                BackgroundColor = Color.Transparent,
                ItemsSource = Pages,
                ItemTemplate = new DataTemplate (typeof(TextCell))
            };
            menuList.ItemTemplate.SetBinding (TextCell.TextProperty, "Title");

            Master = new ContentPage {
                BackgroundColor = Color.FromHex("363636"),
                Title = "Menu",
                Content = menuList
            };

            Detail = new NavigationPage(new ContentPage { 
                Padding = new Thickness(20, 20),
                Content = new StackLayout{ 
                    Children = {
                        new Label { Text = "Select a menu item" }
                    }
                }
            });

            menuList.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				var page = e.SelectedItem as NavigationPage;

                if (page != null) {
                    Detail = page;
                    IsPresented = false;
                }
            };
        }

        void InitPages()
        {
			this.Pages = new List<NavigationPage> ();

            for (int i = 1; i <= 10; i++) {
                var btnSubPage = new Button { 
                    Text = String.Format ("Open sub-page"), 
                };
                btnSubPage.Clicked += delegate {
                    OpenSubPage(String.Format("Sub for page: {0}", i));
                };
                var page = new ContentPage {
                    Padding = new Thickness(20, 20),
                    Title = String.Format("Page {0}", i),
                    Content = new StackLayout {
                        Children = {
                            new Label { Text = String.Format("Page {0}", i) },
                            btnSubPage
                        }
                    }
                };

                page.ToolbarItems.Add(new ToolbarItem("START", null, delegate {
                    Application.Current.MainPage = App.MenuPage;
                }));


				this.Pages.Add (new NavigationPage(page) { Title = page.Title});
            }
        }

        public void OpenPage(int index)
        {
            if (index >= Pages.Count) {
                // Index out of range
                return;
            }

            Detail = Pages [index];
        }

        void OpenSubPage(string text)
        {
            Detail.Navigation.PushAsync (new ContentPage {
                Content = new Label { Text = text }
            });
        }
    }
}

