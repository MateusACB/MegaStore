using MegaStore.Controller;
using MegaStore.View;

Controller controller = new Controller();
controller.Start();

Console.WriteLine($"Welcome to MegaStore!");
Console.WriteLine();

InitialMenu initialMenu = new InitialMenu();
initialMenu.MegaStoreMenu(controller);