using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FiapFood.View;
using System.ComponentModel;

namespace FiapFood.ViewModel
{
    [ObservableObject]
    public partial class LoginViewModel
    {

        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string senha;

        [ObservableProperty]
        private bool loginProcessing;


        [RelayCommand]
        public async Task LoginClicked()
        {
            LoginProcessing = true;
            await Task.Delay(2000);
            LoginProcessing = false;

            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }


        [RelayCommand]
        public async Task RegistroClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginRegistroPage)}");
        }



    }
}
