using Domain.Consts;
using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Factories;

public interface IPackingListFactory
{
	PackingList Create(PackingListId id, PackingListName name, Localization localization);
	PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, Localization localization, 
		TravelDays days, Gender gender, Temperature temperature);
}
