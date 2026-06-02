namespace MegaStore.View;

internal class InitialMenu : Menu
{
    public void MegaStoreMenu(Controller.Controller controller)
    {
        while (true)
        {
            Console.WriteLine("MegaStore Menu");
            Console.WriteLine("1 Login");
            Console.WriteLine("2 Sign up");
            Console.WriteLine("3 Continue without login");
            Console.WriteLine("0 Exit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    LoginMenu loginMenu = new LoginMenu();
                    loginMenu.Login(controller);
                    continue;
                case "2":
                    CreateUserMenu createUserMenu = new CreateUserMenu();
                    createUserMenu.CreateUser(controller);
                    continue;
                case "3":
                    // Continue without login logic would go here
                    ConfirmReturnToPreviousMenu();
                    continue;
                case "0":
                    Console.WriteLine("\nPress any key to exit.");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("\nInvalid choice.");
                    ConfirmReturnToPreviousMenu();
                    continue;
            }
        }
    }
}
