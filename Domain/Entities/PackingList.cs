using Domain.Exceptions;
using Domain.ValueObjects;

using Shared.Abstractions.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class PackingList : AggregateRoot<Guid>
{
	public Guid Id { get; private set; }
	private PackingListName _name;
	private Localization _licalization;

	private readonly LinkedList<PackingItem> _items = new();

	internal PackingList(Guid id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
	{
		Id = id;
		_name = name;
		_licalization = localization;
	}

	public void AddItem(PackingItem item)
	{
		if(_items.Any(i => i.Name == item.Name)) throw new PackingItemAlreadyExistsException(_name, item.Name);
		_items.AddLast(item);
	}

	public void RemoveItem(PackingItem item)
	{
		_items.Remove(item);
	}
}
