using Domain.ValueObjects;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Policies.Universal;

internal sealed class BasicPolicy: IPackingItemsPolicy
{
	private const uint MaximumQuantityOfClothes = 7;
	public bool IsApplicable(PolicyData _) => true;
	public IEnumerable<PackingItem> GenerateItems(PolicyData data)
		=> new List<PackingItem>
		{
			new ("Pants", Math.Min(data.Days, MaximumQuantityOfClothes)),
			new ("Socks", Math.Min(data.Days, MaximumQuantityOfClothes)),
			new ("T-shirt", Math.Min(data.Days, MaximumQuantityOfClothes)),
			new ("Trousers", data.Days < 7 ? 1u : 2u),
			new ("Shampoo",1),
			new ("Toothbrush",1),
			new ("Toothpast",1),
			new ("Backpack",1),
			new ("Passport",1),
			new ("Phone charger",1),
		};
}
