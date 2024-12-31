using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitOrderConsole.State
{
	public class Basket(int maxItemThreshold)
	{
		public readonly List<Fruit.Fruit> Contents = [];
		public int MaxItemThreshold = maxItemThreshold;

		public int SpaceRemaining()
		{
			return MaxItemThreshold - Contents.Count;
		}
		public bool AddFruit(Fruit.Fruit fruit, int requestedQuantity)
		{
			if (requestedQuantity <= SpaceRemaining())
			{
				Contents.AddRange(Enumerable.Repeat(fruit, requestedQuantity));
				return true;
			}
			else
			{
				return false;
			}
		}
		public decimal TotalWeight()
		{
			return Contents.Sum(f => f.Weight);
		}
		public decimal TotalPrice()
		{
			return Math.Round(Contents.Sum(f => (f.Price * f.Weight)), 2);
		}
	}
}