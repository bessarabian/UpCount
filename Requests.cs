﻿using RestSharp;
using Newtonsoft.Json;

namespace UpCount
{
    public class Requests
    {
        public async void TestGetRequest(string to, string from, int amount)
        {
            RestClient client = new RestClient("https://api.apilayer.com/exchangerates_data");
            RestRequest request = new RestRequest($"convert?to={to}&from={from}&amount={amount}");
            request.AddHeader("apikey", "OqP8tWMDIfHN6ca0ve0NQJuV4z0XfQGG");
            

            RestResponse response = client.Get(request);

            ConvertResult conv = JsonConvert.DeserializeObject<ConvertResult>(response.Content);

            System.Console.WriteLine(conv.Result);
        }
    }
}