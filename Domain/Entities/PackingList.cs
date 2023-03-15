using Domain.Events;
using Domain.Exceptions;
using Domain.ValueObjects;

using Shared.Abstractions.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class PackingList : AggregateRoot<PackingListId>
{
	public PackingListId Id { get; private set; }
	private PackingListName _name;
	private Localization _licalization;

	private readonly LinkedList<PackingItem> _items = new();

	private PackingList(PackingListId id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
		: this (id, name, localization)
	{
		_items = items;
	}

	internal PackingList(PackingListId id, PackingListName name, Localization localization)
	{
		Id = id;
		_name = name;
		_licalization = localization;
	}

	public void AddItem(PackingItem item)
	{
		if(_items.Any(i => i.Name == item.Name)) throw new PackingItemAlreadyExistsException(_name, item.Name);
		_items.AddLast(item);
		AddEvent(new PackingListItemAddedEvent(this, item));
	}

	public void AddItems(IEnumerable<PackingItem> items)
	{
		foreach(var item in items)
		{
			AddItem(item);
		}
	}

	public void PackItem(string ItemName)
	{
		var item = GetItem(ItemName);
		var PackedItem = item with { IsPacked = true };

		_items.Find(item)!.Value = PackedItem;
		AddEvent(new PackingItemPackedEvent(this, item));
	}

	private PackingItem GetItem(string ItemName)
	{
		var item = _items.SingleOrDefault(i => i.Name == ItemName);
		return item is null ? throw new PackingItemNotFoundException(ItemName) : item;
	}

	public void RemoveItem(string itemName)
	{
		var item = GetItem(itemName);
		_items.Remove(item);
		AddEvent(new PackingListItemRemovedEvent(this, item));
	}
}
