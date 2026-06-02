namespace MegaStore.View;

internal class LoginMenu : Menu
{
    public void Login(Controller.Controller controller)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Login Menu");
            Console.Write($"\nEmail: ");
            string email = Console.ReadLine();
            Console.Write($"Password: ");
            string password = Console.ReadLine();
            var user = controller.users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            if (user != null)
            {
                Console.WriteLine($"\nWelcome, {user.Name}!");
                LoggedMenu loggedMenu = new LoggedMenu();
                if (!loggedMenu.ShowLoggedMenu(controller, user))
                {
                    return;
                }
            }
            else
            {
                Console.WriteLine("\nInvalid email or password.");

                if (!TryAgainOrReturnToPreviousMenu())
                {
                    return;
                }
            }
        }
    }
}
