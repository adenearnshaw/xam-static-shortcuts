using System;
using AppShortcutsSample.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShortcutsSample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void FavoritesLinkClicked(object sender, EventArgs e)
        {
            await NavigationService.Instance.Navigate(new FavoritesPage());
        }
    }
}