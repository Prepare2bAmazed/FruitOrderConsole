using FruitOrderConsole.State;

namespace FruitOrderConsole.Utility
{
	public static class InputHandler
	{
		public static bool HandleInput(AppState appState, string input)
		{
			if (short.TryParse(input, out short parsedInt)
				&& parsedInt >= 0
				&& appState.CustomerBasket.AddFruit(appState.FruitInventory[appState.CurrentInventoryIndex], parsedInt)
			)
			{
				appState.CurrentInventoryIndex++;
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
