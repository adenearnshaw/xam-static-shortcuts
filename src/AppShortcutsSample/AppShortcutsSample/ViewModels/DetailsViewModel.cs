using AppShortcutsSample.Data;
using AppShortcutsSample.Models;
using MvvmHelpers;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppShortcutsSample.ViewModels
{
    public class DetailsViewModel : BaseViewModel
    {
        public DetailsViewModel(Monkey monkey)
        {
            Monkey = monkey;
            ToggleMonkeyPreferenceCommand = new Command(ToggleMonkeyPreference);
        }

        public Monkey Monkey { get; private set; }

        public ICommand ToggleMonkeyPreferenceCommand { get; private set; }


        private void ToggleMonkeyPreference()
        {
            IsBusy = true;

            try
            {
                MonkeyStore.Instance.SetMonkeyPreference(Monkey.Id, !Monkey.IsFavorited);
                OnPropertyChanged(nameof(Monkey));
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
