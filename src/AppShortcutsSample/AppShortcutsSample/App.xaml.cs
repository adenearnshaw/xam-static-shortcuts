using AppShortcutsSample.Data;
using AppShortcutsSample.Views;
using System;
using System.Linq;
using Xamarin.Forms;

namespace AppShortcutsSample
{
    public partial class App : Application
    {
        public const string AppShortcutUriBase = "stc://appshortcuts/monkey/";

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

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            var monkeyId = uri.ToString().Replace(AppShortcutUriBase, "");
            var monkey = MonkeyStore.Instance.Monkeys.FirstOrDefault(m => m.Id.Equals(monkeyId));

            if (monkey != null)
                MainPage.Navigation.PushAsync(new DetailsPage(monkey));
            else
                base.OnAppLinkRequestReceived(uri);
        }
    }
}
