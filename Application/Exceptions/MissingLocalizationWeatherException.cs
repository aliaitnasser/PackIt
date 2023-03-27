using Domain.ValueObjects;

using Shared.Abstractions.Exceptions;

namespace Application.Exceptions;

public class MissingLocalizationWeatherException: PackItException
{
	public Localization Localization { get; }

	public MissingLocalizationWeatherException(Localization localization) 
		: base($"Could't fetch weather data for localization {localization.City} - {localization.Country}")
	{
		Localization = localization;
	}
}
