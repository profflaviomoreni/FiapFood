using FiapFood.View;
using MonkeyCache.LiteDB;

namespace FiapFood
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Barrel.ApplicationId = "FiapFoodCache";

            MainPage = new AppShell();
        }


        protected override async void OnStart()
        {
            if ( ! string.IsNullOrEmpty(Preferences.Default.Get("RefreshToken", string.Empty)) )
            {
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }

            base.OnStart();
        }

    }
}