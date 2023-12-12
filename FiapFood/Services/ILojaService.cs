using FiapFood.Models;

namespace FiapFood.Services
{
    public interface ILojaService
    {

        public Task<IList<LojaResponse>> FindAll();


    }
}
