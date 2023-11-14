namespace FiapFood.View;

public partial class LojasPage : ContentPage
{
	public LojasPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(ProdutoDetalhePage));
    }
}