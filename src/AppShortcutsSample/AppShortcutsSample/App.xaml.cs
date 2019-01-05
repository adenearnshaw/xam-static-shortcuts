using AppShortcutsSample.Data;
using AppShortcutsSample.Views;
using System;
using AppShortcutsSample.Services;
using Xamarin.Forms;

namespace AppShortcutsSample
{
    public partial class App : Application
    {
        public const string AppShortcutUriBase = "stc://staticshortcuts/";
        private const string ShortcutKey_Favorite = "favorites";

        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailPage
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new MainPage())
                {
                    BarBackgroundColor = Color.FromHex("#252C35"),
                    BarTextColor = Color.White
                }
            };
        }

        protected override async void OnAppLinkRequestReceived(Uri uri)
        {
            var shortcutKey = uri.ToString().Replace(AppShortcutUriBase, "");

            if (shortcutKey == ShortcutKey_Favorite)
                await NavigationService.Instance.Navigate(new FavoritesPage());
            else
                base.OnAppLinkRequestReceived(uri);
        }
    }
}
