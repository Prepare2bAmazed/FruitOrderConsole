using FruitOrderConsole.State;

namespace FruitOrderConsole.Utility
{
	public static class StringMaker
	{
		public static string FruitQuestion(AppState appState)
		{
			return $"How many {appState.FruitInventory[appState.CurrentInventoryIndex].Name}s do you want? Enter a number between 0 and {appState.CustomerBasket.SpaceRemaining()}: ";
		}
		public static string TotalWeight(AppState appState)
		{
			return $"Total basket weight: {appState.CustomerBasket.TotalWeight()} lbs";
		}
		public static string TotalPrice(AppState appState)
		{
			return $"Total price of fruit: ${appState.CustomerBasket.TotalPrice()}";
		}
		public static readonly string Title = new string(' ', 8) + new string('\\', 10) + new string(' ', 10) + "PLACE YOUR ORDER" + new string(' ', 10) + new string('/', 10);
		public static readonly string TryAgain = "Please try again.";
		public static readonly string Done = "Press any key to close the console";
		public static readonly string DividingLine = "\n" + (new string('=', 75) + "\n");
	}
}