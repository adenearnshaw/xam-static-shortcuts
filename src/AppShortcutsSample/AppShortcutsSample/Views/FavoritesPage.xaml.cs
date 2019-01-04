using AppShortcutsSample.ViewModels;
using Xamarin.Forms;

namespace AppShortcutsSample.Views
{
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();
            BindingContext = new FavoritesViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            (BindingContext as FavoritesViewModel)?.RefreshMonkeysCommand.Execute(null);
        }
    }
}
