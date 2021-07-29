using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using TheOddsApi.Models;

namespace TheOddsApi
{
    class Program
    {
        static Settings _settings;
        static readonly HttpClient _client = new HttpClient();

        static async Task Main(string[] args)
        {
            _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText("appsettings.json"));

            await GetAllSports();
        }

        static async Task GetAllSports()
        {
            var uri = new Uri($"{_settings.TheOddsApi.BaseUrl}/sports?apiKey={_settings.TheOddsApi.Key}");
            var response = await _client.GetAsync(uri);

            var model = JsonConvert.DeserializeObject<List<Sports>>(await response.Content.ReadAsStringAsync());
        }
    }
}
