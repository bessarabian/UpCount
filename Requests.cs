using RestSharp;
using System;
using System.IO;

namespace UpCount
{
    public class Requests
    {
        public void TestGetRequest(string to, string from, int amount)
        {
            RestClient client = new RestClient("https://api.apilayer.com/exchangerates_data");
            RestRequest request = new RestRequest("https://www.google.com"/*$"/convertconvert?to={to}&from={from}&amount={amount}"*/);
            
            RestResponse response = client.Execute(request);

            Console.WriteLine(response.StatusCode);
        }
    }
}
