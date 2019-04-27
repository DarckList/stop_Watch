using System;
using System.Diagnostics;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace stop_Watch
{
    public partial class App : Application
    {
        Watcher watcher = new Watcher();

        public App()
        {
            InitializeComponent();
            MainPage = watcher;
        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");

            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            base.OnSleep();
            Debug.WriteLine("OnSleep");
            watcher.runing = false;
        }

        protected override void OnResume()
        {
            base.OnResume();
            Debug.WriteLine("OnResume");
            watcher.RunTimer();
            // Handle when your app resumes
        }
    }
}
