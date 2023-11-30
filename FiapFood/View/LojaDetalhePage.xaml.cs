using FiapFood.Models;
using FiapFood.ViewModel;

namespace FiapFood.View;

public partial class LojaDetalhePage : ContentPage
{

    //public LojaDetalheViewModel ParamLojaDetalheViewModel { get; set; }


	public LojaDetalhePage(LojaDetalheViewModel lojaDetalheViewModel)
	{
		InitializeComponent();
		//if (ParamLojaDetalheViewModel == null)
		//{
            BindingContext = lojaDetalheViewModel;
        //} else
		//{
        //    BindingContext = ParamLojaDetalheViewModel;
        //}
		
	}
}