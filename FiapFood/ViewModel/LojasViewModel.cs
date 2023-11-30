using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FiapFood.Models;
using FiapFood.View;
using System.Collections.ObjectModel;

namespace FiapFood.ViewModel
{
    [ObservableObject]
    public partial class LojasViewModel
    {
        [ObservableProperty]
        private LojaResponse lojaSelecionada;

        [ObservableProperty]
        private ObservableCollection<LojaResponse> lojas;

        [ObservableProperty]
        private string busca;


        [RelayCommand]
        public async Task Buscar()
        {
            var lojasFiltradas = GetLojasMockup();
            lojasFiltradas = new ObservableCollection<LojaResponse>(
                lojasFiltradas.Where(l => l.Tipo.ToLower().Contains( busca.ToLower() ))
            );
            Lojas = lojasFiltradas;
        }


        [RelayCommand]
        public async Task SelecionarLoja()
        {
            if (LojaSelecionada != null)
            {
                //var paramLojaDetalheVM = new LojaDetalheViewModel(LojaSelecionada);

                var navParameters = new Dictionary<string, object> { 
                    { "Loja", LojaSelecionada} 
                };

                await Shell.Current.GoToAsync($"{nameof(LojaDetalhePage)}", navParameters);

            }
        }



        public LojasViewModel()
        {
            Lojas = GetLojasMockup();
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


    }
}
