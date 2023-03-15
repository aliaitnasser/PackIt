using Domain.Entities;
using Domain.ValueObjects;

using Shared.Abstractions.Domain;

namespace Domain.Events;

public sealed record PackingListItemAddedEvent(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
