namespace MegaStore.View;
using MegaStore.Model;

internal class LoggedMenu : Menu
{
    public bool ShowLoggedMenu(Controller.Controller controller, User user)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome, {user.Name}!");
            Console.WriteLine("1 View Products");
            Console.WriteLine("2 View Cart");
            Console.WriteLine("3 Logout");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    //ProductMenu
                    break;
                case "2":
                    //CartMenu
                    break;
                case "3":
                    Console.WriteLine($"\nGoodbye {user.Name}!");
                    ConfirmReturnToInitialMenu();
                    return false;
                default:
                    Console.WriteLine("\nInvalid option. ");
                    Console.WriteLine("Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
