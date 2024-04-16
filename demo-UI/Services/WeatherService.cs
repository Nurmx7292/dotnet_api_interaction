using dotnet.common;
using dotnet.common.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace demo_UI.Services
{
    public class WeatherService : IWeatherService
{
    private HttpClient _httpClient { get; }

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherForecast> GetCurrentWeather()
    {
        return await this._httpClient.GetFromJsonAsync<WeatherForecast>("https://localhost:5001/WeatherForecast");
    }
}
}
