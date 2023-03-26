using Shared.Abstractions.Exceptions;

namespace Application.Exceptions;

internal class PackingListAlreadyExistException: PackItException
{
	public string Name { get; }

	public PackingListAlreadyExistException(string name) : base($"Packing list with name '{name}' already exists.")
	{
		Name = name;
	}


}
