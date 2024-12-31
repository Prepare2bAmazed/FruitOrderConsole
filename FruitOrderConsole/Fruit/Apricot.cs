using System;

namespace FruitOrderConsole.Fruit
{	public class Apricot(DateTime datePicked, string color, decimal weight, decimal price) : Fruit("apricot", color, weight, price)
	{
		public readonly DateTime DatePicked = datePicked;
	}
}