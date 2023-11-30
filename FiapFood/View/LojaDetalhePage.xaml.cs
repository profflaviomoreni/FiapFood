using FiapFood.Models;

namespace FiapFood.View;

[QueryProperty("Loja", "Loja")]
public partial class LojaDetalhePage : ContentPage
{

	private LojaResponse loja;

	public LojaResponse Loja
	{
		get { return loja; }
		set { 
			loja = value; 
			OnPropertyChanged();
		}
	}


	public LojaDetalhePage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}