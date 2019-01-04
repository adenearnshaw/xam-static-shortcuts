using AppShortcutsSample.Data;
using AppShortcutsSample.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using AppShortcutsSample.Services;
using AppShortcutsSample.Views;
using Xamarin.Forms;

namespace AppShortcutsSample.ViewModels
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>(MonkeyStore.Instance.Monkeys);
            NavigateToMonkeyDetailCommand = new Command<Monkey>(async monkey => await NavigateToMonkeyDetail(monkey));
        }

        public ObservableCollection<Monkey> Monkeys { get; set; }

        public ICommand NavigateToMonkeyDetailCommand { get; }

        private async Task NavigateToMonkeyDetail(Monkey monkey)
        {
            await NavigationService.Instance.Navigate(new DetailsPage(monkey));
        }
    }
}
