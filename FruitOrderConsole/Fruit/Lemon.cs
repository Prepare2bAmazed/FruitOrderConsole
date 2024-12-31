namespace FruitOrderConsole.Fruit
{
	public class Lemon(int phMeter, string color, decimal weight, decimal price) : Fruit("lemon", color, weight, price)
	{
		public readonly int PhMeter = phMeter > 7 ? 7 : (phMeter < -7 ? -7 : phMeter);
	}
}