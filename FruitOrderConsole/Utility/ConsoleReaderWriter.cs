using FruitOrderConsole.State;
using System;

namespace FruitOrderConsole.Utility
{
	public static class ConsoleReaderWriter
	{
		public static void Title()
		{
			Console.WriteLine(StringMaker.DividingLine);
			Console.WriteLine(StringMaker.Title);
			Console.WriteLine(StringMaker.DividingLine);
		}
		public static void RecursiveLogic(AppState appState)
		{
			if (appState.ReadyForTotals())
			{
				Console.WriteLine(StringMaker.DividingLine);
				Console.WriteLine(StringMaker.TotalWeight(appState));
				Console.WriteLine(StringMaker.TotalPrice(appState));
				Console.WriteLine(StringMaker.DividingLine);
				Console.WriteLine(StringMaker.Done);
				Console.ReadLine();
			}
			else
			{
				Console.Write(StringMaker.FruitQuestion(appState));
				if (!InputHandler.HandleInput(appState, Console.ReadLine()))
				{
					Console.WriteLine(StringMaker.TryAgain);
				}
				RecursiveLogic(appState);
			}
		}
	}
}