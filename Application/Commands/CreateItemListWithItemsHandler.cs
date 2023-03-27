using Application.Exceptions;
using Application.Services;

using Domain.Factories;
using Domain.Repositories;
using Domain.ValueObjects;

using Shared.Abstractions.Commands;

namespace Application.Commands;

public class CreateItemListWithItemsHandler: ICommandHandler<CreateItemListWithItems>
{
	private readonly IPackingListRepository _repository;
	private readonly IPackingListFactory _factory;
	private readonly IPackingListReadService _readService;
	private readonly IWeatherService _weatherService;

	public CreateItemListWithItemsHandler(IPackingListRepository repository, IPackingListFactory factory, 
		IPackingListReadService readService, IWeatherService weatherService)
    {
		_repository = repository;
		_factory = factory;
		_readService = readService;
		_weatherService = weatherService;
	}

    public async Task HandleAsync(CreateItemListWithItems command)
	{
		var (id, name, localizationWriteModel, days, gender) = command;

		if (await _readService.ExistsByNameAsync(name))
			throw new PackingListAlreadyExistException(name);

		var localization = new Localization(localizationWriteModel.City, localizationWriteModel.Country);

		var weather = await _weatherService.GetWeatherAsync(localization);

		if (weather is null)
			throw new MissingLocalizationWeatherException(localization);

		var packingList = _factory.CreateWithDefaultItems(id, name, localization, days, gender, weather.Temperature);

		await _repository.AddAsync(packingList);
	}
}
