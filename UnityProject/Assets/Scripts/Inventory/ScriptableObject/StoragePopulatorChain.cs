
using UnityEngine;

/// <summary>
/// ItemStoragePopulator which simply chains together multiple ItemStoragePopulators
/// </summary>
[CreateAssetMenu(fileName = "StoragePopulatorChain", menuName = "Inventory/StoragePopulatorChain", order = 3)]
public class StoragePopulatorChain : ItemStoragePopulator
{
	[Tooltip("Sequence of populators to use. They are executed in order, so if multiple populators populate the same slot," +
	         " the first one will take precedence.")]
	public ItemStoragePopulator[] Populators;
	public override void PopulateItemStorage(ItemStorage toPopulate)
	{
		foreach (var populator in Populators)
		{
			populator.PopulateItemStorage(toPopulate);
		}
	}
}
