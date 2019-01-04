﻿using System;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.Platform.UWP;

namespace AppShortcutsSample.UWP
{
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new App());
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            OnLaunchedEvent(e.Parameter.ToString());
        }

        public void OnLaunchedEvent(string arguments)
        {
            if (!string.IsNullOrEmpty(arguments))
            {
                var argsUri = new Uri("");
                Xamarin.Forms.Application.Current.SendOnAppLinkRequestReceived(argsUri);
            }
        }
    }
}
