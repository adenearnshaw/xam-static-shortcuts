using AppShortcutsSample.Models;
using AppShortcutsSample.ViewModels;
using Xamarin.Forms;

namespace AppShortcutsSample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void MonkeyListItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        // TODO: Remove
        //public void MonkeyListItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var monkey = ((ListView)sender).SelectedItem as Monkey;
        //    if (monkey == null)
        //        return;

        //    (BindingContext as MainViewModel)?.NavigateToMonkeyDetailCommand.Execute(monkey);
        //}
    }
}
