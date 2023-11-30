using FiapFood.ViewModel;

namespace FiapFood.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
        BindingContext = loginViewModel;
    }
    
}