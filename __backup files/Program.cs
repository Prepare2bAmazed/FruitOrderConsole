using System;
using System.Collections.Generic;
using System.Linq;

/*
 To Do 
SIngleton state
Unit tests
Any redundant code
Cursor stuff instead of please try again
 */
namespace FramwworkConsoleApp
{
	internal class Program
	{
		static void Main()
		{
			//singleton?
			AppState appState = new AppState(fruitInventory: CurrentInventory.FruitsForSale(), maxBasketItemCount: 10);
			AppLogic.FruitQuestionsRecursive(appState);
		}
	}
	public class AppState
	{
		public readonly List<Fruit> FruitInventory;
		public int CurrentInventoryIndex = 0;
		public Basket CustomerBasket;
		public AppState(List<Fruit> fruitInventory, int maxBasketItemCount)
		{
			FruitInventory = fruitInventory;
			CustomerBasket = new Basket(maxBasketItemCount);
		}
	}
	public static class AppLogic
	{
		private static readonly string DividingLine = "\n"+ (new string('=', 75) + "\n");
		public static void FruitQuestionsRecursive(AppState appState)
		{
			if
			(
				appState.CustomerBasket.SpaceRemaining() == 0 
				|| appState.CurrentInventoryIndex > (appState.FruitInventory.Count() - 1)
			)
			{
				Console.WriteLine(DividingLine);
				Console.WriteLine($"Total basket weight: {appState.CustomerBasket.TotalWeight()} lbs");
				Console.WriteLine($"Total price of fruit: ${appState.CustomerBasket.TotalPrice()}");
				Console.WriteLine(DividingLine);
				Console.WriteLine("Press any key to close the console");
				Console.ReadLine();
			}
			else
			{
				Console.Write($"How many {appState.FruitInventory[appState.CurrentInventoryIndex].Name}s do you want? Enter a number between 0 and {appState.CustomerBasket.SpaceRemaining()}: ");
				HandleInput(appState);
				FruitQuestionsRecursive(appState);
			}
		}
		//See if the read/write can be taken out for testing
		public static void HandleInput(AppState appState)
		{
			Int16 parsedInt;
			if
			(
				Int16.TryParse(Console.ReadLine(), out parsedInt)
				&& parsedInt >= 0
				&& appState.CustomerBasket.AddFruit(appState.FruitInventory[appState.CurrentInventoryIndex], parsedInt)
			)
			{
				appState.CurrentInventoryIndex++;
			}
			else
			{
			//Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
			//HandleInput(appState);
			//https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
				Console.WriteLine("Please try again.");
			}
		}
	}
	public static class CurrentInventory
	{ 
		public static List<Fruit> FruitsForSale()
		{
			return new List<Fruit>()
			{
				new Kiwi(
					fuzzLevel: 99887223,
					color: Colors.Brown,
					weight: (decimal)0.18,
					price: (decimal)1.49
				),
				new Apricot(
					datePicked: new DateTime(2024, 12, 10),
					color : Colors.Orange,
					weight: (decimal)0.77,
					price: (decimal)0.45
				),
				new Guava(
					seedless: true,
					color: Colors.Green,
					weight: (decimal)0.33,
					price: (decimal)5.49
				),
				new Mango(
					countryOfOrigin: "India",
					color: Colors.Green,
					weight :(decimal) 0.88,
					price :(decimal) 0.53
				),
				new Lemon(
					phMeter: 5,
					color: Colors.Yellow,
					weight :(decimal) 0.25,
					price :(decimal) 2.99
				),
			};
		}
	}
	public class Basket
	{
		List<Fruit> Contents = new List<Fruit>();
		public int MaxItemThreshold;
		public Basket(int maxItemThreshold)
		{
			MaxItemThreshold = maxItemThreshold;
		}
		public int SpaceRemaining()
		{
			return MaxItemThreshold - Contents.Count();
		}
		public bool AddFruit(Fruit fruit, int requestedQuantity)
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
	public abstract class Fruit
	{
		public string Name;
		public string Color;
		public decimal Weight;
		public decimal Price;
		public Fruit(string name, string color, decimal weight, decimal price)
		{
			Name = name;
			Color = color;
			Weight = weight;
			Price = price;
		}
	}
	public class Kiwi : Fruit
	{
		Int64 FuzzLevel;
		public Kiwi(Int64 fuzzLevel, string color, decimal weight, decimal price) : base("kiwi", color, weight, price)
		{
			FuzzLevel = fuzzLevel;
		}
	}
	public class Apricot : Fruit
	{
		DateTime DatePicked;
		public Apricot(DateTime datePicked, string color, decimal weight, decimal price) : base("apricot", color, weight, price)
		{
			DatePicked = datePicked;
		}
	}
	public class Guava : Fruit
	{
		bool Seedless;
		public Guava(bool seedless, string color, decimal weight, decimal price) : base("guava", color, weight, price)
		{
			Seedless = seedless;
		}
	}
	public class Mango : Fruit
	{
		string CountryOfOrigin;
		public Mango(string countryOfOrigin, string color, decimal weight, decimal price) : base("mango", color, weight, price)
		{
			CountryOfOrigin = countryOfOrigin;
		}
	}
	public class Lemon : Fruit
	{
		int PhMeter;
		public Lemon(int phMeter, string color, decimal weight, decimal price) : base("lemon", color, weight, price)
		{
			PhMeter = phMeter > 7 ? 7 : (phMeter < -7 ? -7 : phMeter);
		}
	}
	public static class Colors
	{
		public static string Red = "red";
		public static string Orange = "orange";
		public static string Yellow = "yellow";
		public static string Green = "green";
		public static string Blue = "blue";
		public static string Violet = "violet";
		public static string Brown = "brown";
	}
}