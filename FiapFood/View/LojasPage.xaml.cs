using FiapFood.Models;
using FiapFood.ViewModel;
using System.Collections.ObjectModel;

namespace FiapFood.View;

public partial class LojasPage : ContentPage
{

    public LojasPage(LojasViewModel lojasViewModel)
	{
		InitializeComponent();
        BindingContext = lojasViewModel;
    }

}