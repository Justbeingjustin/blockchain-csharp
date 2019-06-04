using Blockchain.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;

namespace Blockchain.Services
{
    public class WalletRepository
    {
        private readonly string _apiKey;
        private readonly string _address;
        private string baseUrl = @"https://blockchain.info/balance?active=";

        public WalletRepository(string apiKey, string address)
        {
            _apiKey = apiKey;
            _address = address;
        }

        public BalanceResponse GetBalance()
        {
            var client = new RestClient(baseUrl + _address + "&password=" + _apiKey);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var balanceResponse = JsonConvert.DeserializeObject<Dictionary<string, BalanceResponse>>(response.Content).First();
            return new BalanceResponse()
            {
                FinalBalance = balanceResponse.Value.FinalBalance,
                NumberOfTransactions = balanceResponse.Value.NumberOfTransactions,
                TotalReceived = balanceResponse.Value.TotalReceived,
                Address = balanceResponse.Key
            };
        }
    }
}