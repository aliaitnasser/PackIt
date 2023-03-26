﻿using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Repositories;

public interface IPackingListRepository
{
	Task<PackingList> GetAsync(PackingListId id);
	Task AddAsync (PackingList packingList);
	Task UpdateAsync(PackingList packingList);
	Task DeleteAsync(PackingList packingList);
}
