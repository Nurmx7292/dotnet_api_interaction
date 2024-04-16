using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.common.interfaces
{
    public interface IWeatherService
    {
        public Task<WeatherForecast> GetCurrentWeather();
    }
}
