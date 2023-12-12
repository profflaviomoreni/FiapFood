using FiapFood.Models;
using MonkeyCache.LiteDB;
using System.Text.Json;
using System.Threading;

namespace FiapFood.Services
{
    public class LojaService : ILojaService
    {

        private const string _baseUrl = "https://mauifiap.free.beeceptor.com";

        private const string _cacheKey = "LojasCache";

        public async Task<IList<LojaResponse>> FindAll()
        {

            if ( ! Barrel.Current.IsExpired(_cacheKey) )
            {
                return Barrel.Current.Get<IList<LojaResponse>>(_cacheKey);
            }


            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync($"{_baseUrl}/loja");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonResponse = await response.Content.ReadAsStringAsync();
                        var lojas = JsonSerializer.Deserialize<List<LojaResponse>>(jsonResponse);

                        Barrel.Current.Add(_cacheKey, lojas, TimeSpan.FromMinutes(5));

                        return lojas;
                    }
                    else
                    {
                        throw new Exception($"Erro na requisição: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
