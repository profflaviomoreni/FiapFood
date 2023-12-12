using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FiapFood.Services;
using FiapFood.View;
using System.ComponentModel;

namespace FiapFood.ViewModel
{
    [ObservableObject]
    public partial class LoginViewModel
    {

        private readonly IUsuarioService _usuarioService;

        public LoginViewModel(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;        
        }


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
            
            try
            {
                if ( Xamarin.Essentials.Connectivity.NetworkAccess == Xamarin.Essentials.NetworkAccess.None )
                {
                    throw new Exception("Verifique sua conexão de rede");
                }


                var authResponse = await _usuarioService.Login(email, senha);

                Preferences.Default.Set("Expires", authResponse.Expired);
                Preferences.Default.Set("RefreshToken", authResponse.RefreshToken);

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            } catch (Exception ex) {
                await Toast.Make($"Falha no login. Detalhe: {ex.Message}").Show();             
            } finally { 
                LoginProcessing = false; 
            }
            
        }


        [RelayCommand]
        public async Task RegistroClicked()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginRegistroPage)}");
        }



    }
}
