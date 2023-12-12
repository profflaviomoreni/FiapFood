using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FiapFood.Models;
using FiapFood.Services;
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

        [ObservableProperty]
        public bool isLoading;


        private readonly ILojaService _lojaService;

        public LojasViewModel(ILojaService lojaService)
        {
            _lojaService = lojaService;

            LoadLojas();

        }

        private async void LoadLojas()
        {
            IsLoading = true;

            var listaLojas = await _lojaService.FindAll();
            Lojas = new ObservableCollection<LojaResponse>();

            foreach (var loja in listaLojas)
            {
                Lojas.Add(loja);
            }

            IsLoading = false;
        }

        [RelayCommand]
        public async Task Atualizar()
        {
            Busca = "";
            LoadLojas();
        }


        [RelayCommand]
        public async Task Buscar()
        {
            var lojasFiltradas = Lojas;
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
                var navParameters = new Dictionary<string, object> { 
                    { "Loja", LojaSelecionada} 
                };

                await Shell.Current.GoToAsync($"{nameof(LojaDetalhePage)}", navParameters);

            }
        }


    }
}
