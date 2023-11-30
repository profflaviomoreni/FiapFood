using FiapFood.Models;
using System.Collections.ObjectModel;

namespace FiapFood.View;

public partial class LojasPage : ContentPage
{

    private ObservableCollection<LojaResponse> Lojas { get; set; }


    public LojasPage()
	{
		InitializeComponent();

        Lojas = GetLojasMockup();

        CollectionViewLojas.ItemsSource = Lojas;

    }


    private ObservableCollection<LojaResponse> GetLojasMockup()
    {
        ObservableCollection<LojaResponse> _lojas = new ObservableCollection<LojaResponse>();

        _lojas.Add(new LojaResponse(1, "Loja 1", "place1.png", "Sushi", "Rua A, 123", 5.99));
        _lojas.Add(new LojaResponse(2, "Loja 2", "place2.png", "Pizzaria", "Rua B, 456", 7.99));
        _lojas.Add(new LojaResponse(3, "Loja 3", "place3.png", "Hamburger", "Rua C, 789", 6.49));

        _lojas.Add(new LojaResponse(4, "Loja 4", "place1.png", "Sushi", "Rua A, 123", 5.99));
        _lojas.Add(new LojaResponse(5, "Loja 5", "place2.png", "Pizzaria", "Rua B, 456", 7.99));
        _lojas.Add(new LojaResponse(6, "Loja 6", "place3.png", "Hamburger", "Rua C, 789", 6.49));

        _lojas.Add(new LojaResponse(7, "Loja 7", "place1.png", "Sushi", "Rua A, 123", 5.99));
        _lojas.Add(new LojaResponse(8, "Loja 8", "place2.png", "Pizzaria", "Rua B, 456", 7.99));
        _lojas.Add(new LojaResponse(9, "Loja 9", "place3.png", "Hamburger", "Rua C, 789", 6.49));

        return _lojas;
    }


    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(ProdutoDetalhePage));
    }

    private void SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if ( e.CurrentSelection.Count > 0 )
        {
            var lojaSelecionada = e.CurrentSelection[0] as LojaResponse;
        }
    }

    private void TextoBuscaTextChanged(object sender, TextChangedEventArgs e)
    {
        var lojasFiltradas = new ObservableCollection<LojaResponse>(
                Lojas.Where(l => l.Tipo.ToLower().Contains(e.NewTextValue.ToLower()))
            );

        CollectionViewLojas.ItemsSource = lojasFiltradas;
    }
}