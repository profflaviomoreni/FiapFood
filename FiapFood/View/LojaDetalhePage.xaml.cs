using FiapFood.Models;
using FiapFood.ViewModel;

namespace FiapFood.View;

public partial class LojaDetalhePage : ContentPage
{

	public LojaDetalhePage(LojaDetalheViewModel lojaDetalheViewModel)
	{
		InitializeComponent();
        BindingContext = lojaDetalheViewModel;
	}
}