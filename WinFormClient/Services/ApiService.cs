using System;
using System.Configuration;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WinFormClient.Models;

namespace WinFormClient.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public event Action<int> PayloadReceived;
        readonly string _url;
        public ApiService(string url)
        {
            _url = url;
        }


        public void SendRequest()
        {
            try
            {
                while (true)
                {
                    var response = _httpClient.GetAsync(_url).Result;
                    response.EnsureSuccessStatusCode();
                    var content = response.Content.ReadAsStringAsync().Result;
                    var apiResponseModel = JsonConvert.DeserializeObject<ResponseModel>(content);
                    OnPayloadReceived(apiResponseModel.Data.Number);
                    Console.WriteLine(apiResponseModel.Data.Number);
                    Thread.Sleep(10000);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"error: {ex.Message}");
            }
        }

        public void OnPayloadReceived(int payload)
        {
            PayloadReceived?.Invoke(payload);
        }
    }
}