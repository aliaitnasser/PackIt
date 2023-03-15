namespace Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
	public T Id { get; protected set; }
	public int Version { get; protected set; }
	public IEnumerable<IDomainEvent> Events => _events;

	private bool versionIncremented;
	private readonly List<IDomainEvent> _events = new();

	protected void AddEvent(IDomainEvent @event)
	{
		if(!_events.Any() && !versionIncremented)
		{
			Version++;
			versionIncremented = true;
			_events.Add(@event);

		}
	}

	public void ClearEvent() => _events.Clear();

	protected void IncrementVersion()
	{
		if(versionIncremented) return;
		Version++;
		versionIncremented = true;
	}
}
