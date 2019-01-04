using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using AppShortcutsSample.Data;
using AppShortcutsSample.Models;
using AppShortcutsSample.Services;
using AppShortcutsSample.Views;
using MvvmHelpers;
using Xamarin.Forms;

namespace AppShortcutsSample.ViewModels
{
    public class FavoritesViewModel : BaseViewModel
    {

        public FavoritesViewModel()
        {
            FavoriteMonkeys = new ObservableRangeCollection<Monkey>();
            NavigateToMonkeyDetailCommand = new Command<Monkey>(async monkey => await NavigateToMonkeyDetail(monkey));
            RefreshMonkeysCommand = new Command(RefreshMonkeys);
        }

        public ObservableRangeCollection<Monkey> FavoriteMonkeys { get; }

        public ICommand RefreshMonkeysCommand { get; }
        public ICommand NavigateToMonkeyDetailCommand { get; }

        private async Task NavigateToMonkeyDetail(Monkey monkey)
        {
            await NavigationService.Instance.Navigate(new DetailsPage(monkey));
        }

        private void RefreshMonkeys()
        {
            IsBusy = true;
            var monkeys = MonkeyStore.Instance.Monkeys.Where(m => m.IsFavorited);
            FavoriteMonkeys.ReplaceRange(monkeys);

            IsBusy = false;
        }
    }
}
