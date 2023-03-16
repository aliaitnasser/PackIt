using Domain.ValueObjects;

namespace Domain.Policies.Gender;

internal sealed class FemaleGenderPolicy: IPackingItemsPolicy
{
	public bool IsApplicable(PolicyData data) => data.Gender is Consts.Gender.Female;
	public IEnumerable<PackingItem> GenerateItems(PolicyData data)
		=> new List<PackingItem>
		{
			new ("Always", 10),
			new ("Skin care", 5),
			new ("Lipstcik", 2),
		};
}
