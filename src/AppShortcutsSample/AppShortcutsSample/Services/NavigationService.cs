using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppShortcutsSample.Services
{
    public class NavigationService
    {
        private static NavigationService _instance;

        public static NavigationService Instance =>
            _instance ?? (_instance = new NavigationService());

        public async Task Navigate(Page page)
        {
            var masterDetailPage = (App.Current.MainPage as MasterDetailPage);

            if (masterDetailPage == null)
                return;

            masterDetailPage.IsPresented = false;
            await masterDetailPage.Detail.Navigation.PushAsync(page);
        }
    }
}