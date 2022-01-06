using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

// API : https://www.cryptingup.com/api/markets
namespace RedisDemo.Data
{
    public class CryptocurrencyService : ICryptocurrencyService
    {
        private readonly HttpClient httpClient;
        public CryptocurrencyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Cryptocurrency>> GetCryptocurrencies()
        {
            var myPocos =  await httpClient.GetFromJsonAsync<Cryptocurrency[]>("https://www.cryptingup.com/api/markets");
            foreach (var myPoco in myPocos)
                Console.WriteLine(myPoco);
            return myPocos.ToArray();
        }
    }
}
