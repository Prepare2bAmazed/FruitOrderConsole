namespace FruitOrderConsole.Fruit
{
	public abstract class Fruit(string name, string color, decimal weight, decimal price)
	{
		public readonly string Name = name;
		public readonly string Color = color;
		public readonly decimal Weight = weight;
		public readonly decimal Price = price;
	}
}