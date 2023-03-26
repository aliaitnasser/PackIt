using Application.DTO.External;

using Domain.ValueObjects;

namespace Application.Services;

public interface IWeatherService
{
	Task<WeatherDto> GetWeatherAsync(Localization localization);
}
