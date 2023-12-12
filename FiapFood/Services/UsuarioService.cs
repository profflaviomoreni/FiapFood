using FiapFood.Models;
using System.Text;
using System.Text.Json;

namespace FiapFood.Services
{
    public class UsuarioService : IUsuarioService
    {

        private const string _baseUrl = "https://fiapfood.free.beeceptor.com";

        public async Task<AuthResult> Login(string username, string password)
        {
            
            using ( var client = new HttpClient())
            {

                var request = new
                {
                    Username = username,
                    Password = password
                };

                try { 

                    var jsonRequest = JsonSerializer.Serialize(request);
                    var content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");

                    var result = await client.PostAsync($"{_baseUrl}/auth", content);

                    if ( result.IsSuccessStatusCode )
                    {
                        var response = await result.Content.ReadAsStringAsync();
                        var authResult = JsonSerializer.Deserialize<AuthResult>(response);

                        return authResult;
                    } else
                    {
                        throw new Exception("A requisição de autenticação foi inválida");
                    }

                } catch (HttpRequestException ex)
                {
                    throw ex;
                }

            }
        }


    }
}
