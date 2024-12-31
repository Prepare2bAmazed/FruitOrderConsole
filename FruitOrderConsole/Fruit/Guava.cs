namespace FruitOrderConsole.Fruit
{
	public class Guava(bool seedless, string color, decimal weight, decimal price) : Fruit("guava", color, weight, price)
	{
		public readonly bool Seedless = seedless;
	}
}