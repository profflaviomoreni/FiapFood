using FiapFood.View;

namespace FiapFood
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(HomePage) , typeof(HomePage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LojasPage), typeof(LojasPage));
            Routing.RegisterRoute(nameof(LojaDetalhePage), typeof(LojaDetalhePage));
            Routing.RegisterRoute(nameof(ProdutosPage), typeof(ProdutosPage));
            Routing.RegisterRoute(nameof(ProdutoDetalhePage), typeof(ProdutoDetalhePage));
            Routing.RegisterRoute(nameof(LoginRegistroPage), typeof(LoginRegistroPage));

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}