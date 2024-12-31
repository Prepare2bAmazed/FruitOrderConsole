using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitOrderConsole.State;
using FruitOrderConsole.Utility;
using FruitOrderConsole.Fruit;

namespace FruitOrderTest
{
	[TestClass]
	public class FruitOrderCondoleTests
	{
		[TestMethod]
		public void InputHandlerTest()
		{
			AppState appState = new(CurrentInventory.FruitsForSale(), 10);

			Assert.AreEqual(false, InputHandler.HandleInput(appState, "-1"));
			Assert.AreEqual(false, InputHandler.HandleInput(appState, "11"));
			Assert.AreEqual(false, InputHandler.HandleInput(appState, "abc"));
			Assert.AreEqual(true, InputHandler.HandleInput(appState, "5"));
		}

		[TestMethod]
		public void BasketTest()
		{
			Fruit lemon = new Lemon(phMeter: 5, color: Colors.Yellow, weight: (decimal)0.25, price: (decimal)2.99);
			Basket basket = new(3);
			basket.AddFruit(lemon, 2);

			Assert.AreEqual(1, basket.SpaceRemaining());
			Assert.AreEqual((decimal)0.50, basket.TotalWeight());
			Assert.AreEqual((decimal)1.5, basket.TotalPrice());

			basket.AddFruit(lemon, 333);
			Assert.AreEqual(1, basket.SpaceRemaining());

		}
	}
}
