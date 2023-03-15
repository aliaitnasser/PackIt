using Domain.Consts;
using Domain.Entities;
using Domain.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Factories;

public class PackingListFactory: IPackingListFactory
{
	public PackingList Create(PackingListId id, PackingListName name, Localization localization)
	{
		throw new NotImplementedException();
	}

	public PackingList CreateWithDefaultItems(PackingListId id, PackingListName name, Localization localization, 
		TravelDays days, Gender gender, Temperature temperature)
	{
		throw new NotImplementedException();
	}
}
