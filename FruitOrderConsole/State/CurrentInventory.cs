using System;
using System.Collections.Generic;
using FruitOrderConsole.Fruit;

namespace FruitOrderConsole.State
{
	public static class CurrentInventory
	{
		public static List<Fruit.Fruit> FruitsForSale()
		{
			return
			[   new Kiwi(fuzzLevel: 99887223, color: Colors.Brown, weight: (decimal)0.18, price: (decimal)1.49),
				new Apricot(datePicked: new DateTime(2024, 12, 10), color: Colors.Orange, weight: (decimal)0.77, price: (decimal)0.45),
				new Guava(seedless: true, color: Colors.Green, weight: (decimal)0.33, price: (decimal)5.49),
				new Mango(countryOfOrigin: "India", color: Colors.Green, weight: (decimal) 0.88, price: (decimal) 0.53),
				new Lemon(phMeter: 5, color: Colors.Yellow, weight: (decimal) 0.25, price: (decimal) 2.99),
			];
		}
	}
}
