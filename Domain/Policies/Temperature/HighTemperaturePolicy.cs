using Domain.ValueObjects;

namespace Domain.Policies.Temperature;

internal sealed class HighTemperaturePolicy: IPackingItemsPolicy
{
	public bool IsApplicable(PolicyData data) => data.Temperature > 30D;
	public IEnumerable<PackingItem> GenerateItems(PolicyData data)
		=> new List<PackingItem>
		{
			new ("Sunscreen", 1),
			new ("Swimsuit", 1),
			new ("Hat", 1),
		};
}
