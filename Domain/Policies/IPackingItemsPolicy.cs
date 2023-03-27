using Domain.ValueObjects;

namespace Domain.Policies;

public interface IPackingItemsPolicy
{
	bool IsApplicable(PolicyData data);
	IEnumerable<PackingItem> GenerateItems(PolicyData data);
}
