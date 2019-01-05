using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace AppShortcutsSample.Droid
{

    [Activity(Label = "StaticShortcuts Sample",
              Icon = "@drawable/app_icon",
              RoundIcon = "@drawable/app_icon_round",
              Theme = "@style/SplashTheme",
              MainLauncher = true,
              NoHistory = true,
              Exported = true,
              Name = "com.adenearnshaw.StaticShortcutsSample.SplashActivity")]
    [MetaData("android.app.shortcuts", Resource = "@xml/shortcuts")]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();

            var intent = new Intent(Application.Context, typeof(MainActivity));

            // Setting these properties is only required because SplashActivity doesn't
            // call LoadApplication(), so the data must be passed through.
            intent.SetAction(Intent.ActionView);
            intent.SetData(Intent?.Data);

            StartActivity(intent);
        }
    }
}