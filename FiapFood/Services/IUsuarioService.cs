using FiapFood.Models;

namespace FiapFood.Services
{
    public  interface IUsuarioService
    {


        public Task<AuthResult> Login(string username, string password);

    }
}
