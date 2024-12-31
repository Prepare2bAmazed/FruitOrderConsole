namespace FruitOrderConsole.Fruit
{
	public class Mango(string countryOfOrigin, string color, decimal weight, decimal price) : Fruit("mango", color, weight, price)
	{
		public readonly string CountryOfOrigin = countryOfOrigin;
	}
}