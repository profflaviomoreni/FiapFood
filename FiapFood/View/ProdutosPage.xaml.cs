namespace FiapFood.View;

public partial class ProdutosPage : ContentPage
{
	public ProdutosPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(ProdutoDetalhePage));
    }
}