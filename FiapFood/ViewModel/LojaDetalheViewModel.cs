using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FiapFood.Models;
using System.Collections.ObjectModel;

namespace FiapFood.ViewModel
{
    [QueryProperty("Loja", "Loja")]
    [ObservableObject]
    public partial class LojaDetalheViewModel
    {

        [ObservableProperty]
        private LojaResponse loja;


        [ObservableProperty]
        private bool isReady;


        [ObservableProperty]
        private ObservableCollection<Place> locais;


        public LojaDetalheViewModel()
        {

        }


        [RelayCommand]
        public async Task Posicionar()
        {
            var listaLocais = new List<Place>();
            var minhaLocalizacao = await Geolocation.GetLocationAsync();
            if (minhaLocalizacao != null)
            {

                var place1 = new Place()
                {
                    Location = new Location(minhaLocalizacao.Latitude, minhaLocalizacao.Longitude),
                    Address = "Rua Xyz",
                    Description = "Location"
                };

                listaLocais.Add(place1);

            }

            Locais = new ObservableCollection<Place>(listaLocais);
        }



    }
}
