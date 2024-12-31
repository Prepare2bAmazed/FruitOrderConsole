using System;

namespace FruitOrderConsole.Fruit
{
	public class Kiwi(Int64 fuzzLevel, string color, decimal weight, decimal price) : Fruit("kiwi", color, weight, price)
	{
		public readonly Int64 FuzzLevel = fuzzLevel;
	}
}