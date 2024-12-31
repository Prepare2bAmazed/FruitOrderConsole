using System.Collections.Generic;

namespace FruitOrderConsole.State
{
	public class AppState(List<Fruit.Fruit> fruitInventory, int maxBasketItemCount)
	{
		public readonly List<Fruit.Fruit> FruitInventory = fruitInventory;
		public int CurrentInventoryIndex = 0;
		public Basket CustomerBasket = new(maxBasketItemCount);
		public bool ReadyForTotals()
		{
			return CustomerBasket.SpaceRemaining() == 0
			|| CurrentInventoryIndex > (FruitInventory.Count - 1);
		}
	}
}