using CommunityToolkit.Mvvm.ComponentModel;
using FiapFood.Models;

namespace FiapFood.ViewModel
{
    [QueryProperty("Loja", "Loja")]
    [ObservableObject]
    public partial class LojaDetalheViewModel
    {

        [ObservableProperty]
        private LojaResponse loja;


        public LojaDetalheViewModel()
        {
        }

        public LojaDetalheViewModel(LojaResponse loja)
        {
            Loja = loja;
        }
    }
}
