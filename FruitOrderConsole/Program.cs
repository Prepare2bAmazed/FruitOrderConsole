using FruitOrderConsole.State;
using FruitOrderConsole.Utility;

AppState appState = new(fruitInventory: CurrentInventory.FruitsForSale(), maxBasketItemCount: 10);
ConsoleReaderWriter.Title();
ConsoleReaderWriter.RecursiveLogic(appState);